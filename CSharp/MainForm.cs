using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Codecs.Decoders;
using Vintasoft.Imaging.Codecs.ImageFiles.Tiff;
using Vintasoft.Imaging.ColorManagement;
using Vintasoft.Imaging.ColorManagement.Icc;
using Vintasoft.Imaging.Metadata;
using Vintasoft.Imaging.UI;
using Vintasoft.Imaging.Utils;

using DemosCommonCode;
using DemosCommonCode.Imaging;
using DemosCommonCode.Imaging.Codecs;
using DemosCommonCode.Imaging.Codecs.Dialogs;
using DemosCommonCode.Imaging.ColorManagement;


namespace MultiPageTiffDemo
{
    /// <summary>
    /// Main form of Multipage TIFF Demo.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Fields

        /// <summary>
        /// Template of the application title.
        /// </summary>
        string _titlePrefix = string.Format("VintaSoft Multipage TIFF Demo v{0}", ImagingGlobalSettings.ProductVersion);

        /// <summary>
        /// TIFF file object that manipulates TIFF file.
        /// </summary>
        TiffFile _tiffFile;

        /// <summary>
        /// Decoding settings of the TIFF file.
        /// </summary>
        DecodingSettings _decodingSettings = new DecodingSettings();

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // register the evaluation license for VintaSoft Imaging .NET SDK
            Vintasoft.Imaging.ImagingGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");

            InitializeComponent();

            // create new TIFF file in memory
            _tiffFile = new TiffFile();


            // get filename of default input CMYK ICC profile
            string defaultInputCmykFilename = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                ColorManagementSettingsForm.DEFAULT_INPUT_CMYK_PROFILE);
            // if ICC profile exists
            if (File.Exists(defaultInputCmykFilename))
            {
                try
                {
                    // create default color management settings
                    ColorManagementDecodeSettings colorManagementSettings = new ColorManagementDecodeSettings();
                    // specify that the color management settings must use ICC profile as input CMYK profile
                    colorManagementSettings.InputCmykProfile = new IccProfile(defaultInputCmykFilename);
                }
                catch
                {
                }
            }

            // update the application's title after TIFF file is created
            UpdateApplicationTitle(null);

            // initialize color management in viewer
            _decodingSettings.ColorManagement = ColorManagementHelper.InitColorManagement(null);

            // update the UI
            UpdateUI();

            // set the initial directory in open dialog
            DemosTools.SetTestFilesFolder(openTiffFileDialog);
            DemosTools.SetTestFilesFolder(openAllImagesFileDialog);

            // set filters in open dialog
            CodecsFileFilters.SetOpenFileDialogFilter(openAllImagesFileDialog);
        }

        #endregion



        #region Properties

        bool _isTiffFileOpening = false;
        /// <summary>
        /// Gets or sets a value indicating whether TIFF file is opening.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal bool IsTiffFileOpening
        {
            get
            {
                return _isTiffFileOpening;
            }
            set
            {
                _isTiffFileOpening = value;
                UpdateUI();
            }
        }

        bool _isTiffFileLocked = false;
        /// <summary>
        /// Gets or sets a value indicating whether TIFF file is locked (image loading,
        /// image adding, file saving, file packing, etc).
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal bool IsTiffFileLocked
        {
            get
            {
                return _isTiffFileLocked;
            }
            set
            {
                if (value)
                    Cursor = Cursors.WaitCursor;
                else
                    Cursor = Cursors.Default;

                _isTiffFileLocked = value;
                UpdateUI();
            }
        }

        #endregion



        #region Methods

        #region UI

        #region 'File' menu

        /// <summary>
        /// Handles the Click event of newToolStripMenuItem object.
        /// </summary>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsTiffFileOpening = true;

            // close current TIFF file if necessary
            CloseFile();

            // get format and version of new TIFF file
            using (CreateNewFileForm createNewFileForm = new CreateNewFileForm())
            {
                createNewFileForm.ShowDialog();

                // create new TIFF file in memory
                _tiffFile = new TiffFile(createNewFileForm.FileFormat, createNewFileForm.FileVersion);

                // update the application title after TIFF file is created
                UpdateApplicationTitle(null);
                // update page count after TIFF file is created
                UpdatePageCount();
            }

            IsTiffFileOpening = false;
        }

        /// <summary>
        /// Handles the Click event of openToolStripMenuItem object.
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsTiffFileOpening = true;

            if (openTiffFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // close current TIFF file
                CloseFile();

                try
                {
                    // open new TIFF file
                    _tiffFile = new TiffFile(openTiffFileDialog.FileName, false);

                    // update the application title after TIFF file is loaded
                    UpdateApplicationTitle(openTiffFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    _tiffFile = null;

                    // update the application title after TIFF file is loaded
                    UpdateApplicationTitle(null);

                    DemosTools.ShowErrorMessage("File load error", ex);
                }
                finally
                {
                    // update page count after TIFF file is loaded
                    UpdatePageCount();
                }

                if (_tiffFile != null)
                    viewerToolStrip.SelectedPageIndex = 0;
                else
                    viewerToolStrip.SelectedPageIndex = -1;
            }

            IsTiffFileOpening = false;
        }

        /// <summary>
        /// Handles the Click event of saveToolStripMenuItem object.
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsTiffFileLocked = true;

            // create progress controller
            IProgressController progressController = new ProgressControllerWithDelegates(ImagesEncodingProgress, ImageEncodingProgress);

            // save changes in current TIFF file
            _tiffFile.SaveChanges(progressController);

            IsTiffFileLocked = false;
        }

        /// <summary>
        /// Handles the Click event of saveAsToolStripMenuItem object.
        /// </summary>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsTiffFileLocked = true;

            if (saveTiffFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // create progress controller
                    IProgressController progressController = new ProgressControllerWithDelegates(ImagesEncodingProgress, ImageEncodingProgress);

                    // save current TIFF file as new file and switch to it
                    _tiffFile.SaveChanges(saveTiffFileDialog.FileName, progressController);

                    // update the application title after TIFF file is saved
                    UpdateApplicationTitle(saveTiffFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    DemosTools.ShowErrorMessage(ex);
                }
            }

            IsTiffFileLocked = false;
        }

        /// <summary>
        /// Handles the Click event of packToolStripMenuItem object.
        /// </summary>
        private void packToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsTiffFileLocked = true;

            // if current TIFF file stored in memory
            if (_tiffFile.Filename == null)
            {
                // pack current TIFF file to new memory stream
                MemoryStream mem = new MemoryStream();
                _tiffFile.Pack(mem);

                // dispose current TIFF file
                _tiffFile.Dispose();

                // update current TIFF file
                mem.Position = 0;
                _tiffFile = new TiffFile(mem);
            }
            // if the current TIFF file is stored on a disk
            else
            {
                string sourceFilename = _tiffFile.Filename;
                string tempFilename = Path.GetTempFileName();

                // pack current TIFF file to a temporary file
                _tiffFile.Pack(tempFilename);

                // dispose the current TIFF file
                _tiffFile.Dispose();

                // remove current TIFF file from disk
                File.Delete(sourceFilename);
                // move temporary file to the location of current TIFF file
                File.Move(tempFilename, sourceFilename);

                // update current TIFF file
                _tiffFile = new TiffFile(sourceFilename);
            }

            IsTiffFileLocked = false;
        }

        /// <summary>
        /// Handles the Click event of closeToolStripMenuItem object.
        /// </summary>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close current TIFF file
            CloseFile();

            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of exitToolStripMenuItem object.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseFile();
            Close();
        }

        #endregion


        #region 'View' menu

        /// <summary>
        /// Handles the Click event of centerImageToolStripMenuItem object.
        /// </summary>
        private void centerImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (centerImageToolStripMenuItem.Checked)
            {
                // enable centering of image in image viewer
                imageViewer1.FocusPointAnchor = AnchorType.None;
                imageViewer1.IsFocusPointFixed = true;
                imageViewer1.ScrollToCenter();
            }
            else
            {
                // disable centering of image in image viewer
                imageViewer1.FocusPointAnchor = AnchorType.Left | AnchorType.Top;
                imageViewer1.IsFocusPointFixed = true;
            }
        }

        /// <summary>
        /// Handles the Click event of imageViewerSettingsToolStripMenuItem object.
        /// </summary>
        private void imageViewerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageViewerSettingsForm viewerSettingsDialog = new ImageViewerSettingsForm(imageViewer1);
            viewerSettingsDialog.CanEditMultipageSettings = false;
            viewerSettingsDialog.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of colorManagementToolStripMenuItem object.
        /// </summary>
        private void colorManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a dialog for editing the color management settings
            using (ColorManagementSettingsForm dlg = new ColorManagementSettingsForm())
            {
                dlg.ColorManagementSettings = _decodingSettings.ColorManagement;

                // show dialog
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _decodingSettings.ColorManagement = dlg.ColorManagementSettings;

                    // update current image in image viewer
                    SetCurrentPageIndex(viewerToolStrip.SelectedPageIndex);
                }
            }
        }

        #endregion


        #region 'Page' menu

        /// <summary>
        /// Handles the Click event of addPagesToolStripMenuItem object.
        /// </summary>
        private void addPagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // add page(s) to the end of file
            InsertPages(_tiffFile.Pages.Count);
        }

        /// <summary>
        /// Handles the Click event of insertPagesBeforeCurrentPageToolStripMenuItem object.
        /// </summary>
        private void insertPagesBeforeCurrentPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int pageIndex = 0;
            if (_tiffFile.Pages.Count > 0)
                pageIndex = viewerToolStrip.SelectedPageIndex;

            // insert page before current page
            InsertPages(pageIndex);
        }

        /// <summary>
        /// Handles the Click event of insertPagesAfterCurrentPageToolStripMenuItem object.
        /// </summary>
        private void insertPagesAfterCurrentPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int pageIndex = 0;
            if (_tiffFile.Pages.Count > 0)
                pageIndex = viewerToolStrip.SelectedPageIndex + 1;

            // insert page after current page
            InsertPages(pageIndex);
        }

        /// <summary>
        /// Handles the Click event of removePageToolStripMenuItem object.
        /// </summary>
        private void removePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int pageIndex = viewerToolStrip.SelectedPageIndex;

                _tiffFile.Pages.RemoveAt(pageIndex);

                if (pageIndex >= _tiffFile.Pages.Count)
                {
                    viewerToolStrip.SelectedPageIndex--;
                }
                else
                {
                    SetCurrentPageIndex(pageIndex);
                }
                // update page count after TIFF file is changed
                UpdatePageCount();

                // update the UI
                UpdateUI();
            }
            catch (TiffFileException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of metadataToolStripMenuItem object.
        /// </summary>
        private void metadataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show dialog with metadata of TIFF page
            using (MetadataEditorForm dlg = new MetadataEditorForm())
            {
                int pageIndex = viewerToolStrip.SelectedPageIndex;

                dlg.RootMetadataNode = new TiffPageMetadata(_tiffFile.Pages[pageIndex]);
                dlg.ShowDialog();
            }
        }

        #endregion


        #region 'Help' menu

        /// <summary>
        /// Handles the Click event of aboutToolStripMenuItem object.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBoxForm dlg = new AboutBoxForm())
            {
                dlg.ShowDialog();
            }
        }

        #endregion


        /// <summary>
        /// Handles the PageIndexChanged event of imageViewerToolStrip object.
        /// </summary>
        private void imageViewerToolStrip_PageIndexChanged(object sender, PageIndexChangedEventArgs e)
        {
            SetCurrentPageIndex(e.SelectedPageIndex);
        }

        #endregion


        #region UI state

        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI()
        {
            // get the current status of application
            bool isTiffFileOpening = IsTiffFileOpening;
            bool isTiffFileLoaded = _tiffFile != null;
            bool isTiffFileEmpty = true;
            if (isTiffFileLoaded)
                isTiffFileEmpty = _tiffFile.Pages.Count == 0;
            bool isTiffFileLocked = IsTiffFileLocked;


            // "File" menu
            newFileToolStripMenuItem.Enabled = !isTiffFileLocked;
            openToolStripMenuItem.Enabled = !isTiffFileLocked;
            saveToolStripMenuItem.Enabled = !IsTiffFileOpening && isTiffFileLoaded && !isTiffFileEmpty &&
                                            !isTiffFileLocked;
            saveFileAsToolStripMenuItem.Enabled = !IsTiffFileOpening && isTiffFileLoaded && !isTiffFileEmpty &&
                                                  !isTiffFileLocked;
            packToolStripMenuItem.Enabled = !IsTiffFileOpening && isTiffFileLoaded && !isTiffFileEmpty &&
                                            !isTiffFileLocked;
            closeFileToolStripMenuItem.Enabled = !IsTiffFileOpening && isTiffFileLoaded && !isTiffFileLocked;

            // "Page" menu
            pageToolStripMenuItem.Enabled = !IsTiffFileOpening && isTiffFileLoaded && !isTiffFileLocked;
            removePageToolStripMenuItem.Enabled = !isTiffFileEmpty && !isTiffFileLocked;
            metadataToolStripMenuItem.Enabled = !isTiffFileEmpty && !isTiffFileLocked;

            // ViewerToolStrip
            viewerToolStrip.Enabled = !IsTiffFileOpening;
            viewerToolStrip.SaveButtonEnabled = isTiffFileLoaded && !isTiffFileEmpty;
        }

        /// <summary>
        /// Updates the application title after TIFF file is created/loaded/saved/closed.
        /// </summary>
        /// <param name="filename">The name of the file to set in the title.</param>
        private void UpdateApplicationTitle(string filename)
        {
            if (_tiffFile != null)
            {
                if (filename == null)
                {
                    filename = "(Untitled)";
                }
                this.Text = string.Format("{0} - {1}", _titlePrefix, filename);
            }
            else
            {
                this.Text = _titlePrefix;
            }
        }

        /// <summary>
        /// Updates page count after TIFF file is created/loaded/changed.
        /// </summary>
        private void UpdatePageCount()
        {
            int pageCount = 0;
            if (_tiffFile != null)
            {
                pageCount = _tiffFile.Pages.Count;
            }

            viewerToolStrip.PageCount = pageCount;
        }

        #endregion


        /// <summary>
        /// Closes the current TIFF file.
        /// </summary>
        private void CloseFile()
        {
            // close previously opened TIFF file
            if (_tiffFile != null)
            {
                imageViewer1.Images.ClearAndDisposeItems();

                _tiffFile.Dispose();
                _tiffFile = null;

                // update the application title after TIFF file is closed
                UpdateApplicationTitle(null);

                // update page count after TIFF file is closed
                UpdatePageCount();

                imageInfoLabel.Text = "";
            }
        }

        /// <summary>
        /// Sets the specified page as the current page.
        /// </summary>
        /// <param name="newIndex">New page index.</param>
        private void SetCurrentPageIndex(int newIndex)
        {
            if (_tiffFile == null)
                return;

            if (_tiffFile.Pages.Count > 0 && (newIndex >= _tiffFile.Pages.Count || newIndex < 0))
                return;

            // lock TIFF file
            IsTiffFileLocked = true;

            try
            {
                VintasoftImage previousImage = imageViewer1.Image;

                if (newIndex >= 0)
                {
                    // get reference to the current TIFF page
                    TiffPage currentPage = _tiffFile.Pages[newIndex];

                    // get image of current TIFF page
                    VintasoftImage currentImage = currentPage.GetImage(_decodingSettings, ImageLoadingProgress);

                    // set current image as focused image in image viewer
                    imageViewer1.Image = currentImage;

                    // show information about current image
                    imageInfoLabel.Text = string.Format("Width={0}; Height={1}; Resolution={2}; PixelFormat={3}; Compression={4}",
                        currentPage.Width, currentPage.Height, currentPage.Resolution, imageViewer1.Image.PixelFormat, currentPage.Compression);
                }
                else
                {
                    imageInfoLabel.Text = "";

                    imageViewer1.Image = null;
                }

                if (previousImage != null)
                    previousImage.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (newIndex != viewerToolStrip.SelectedPageIndex)
                viewerToolStrip.SelectedPageIndex = newIndex;

            // unlock TIFF file
            IsTiffFileLocked = false;
        }

        /// <summary>
        /// Inserts pages starting at the specified index.
        /// </summary>
        /// <param name="pageIndex">Index at which pages are inserted.</param>
        private void InsertPages(int pageIndex)
        {
            IsTiffFileLocked = true;

            if (openAllImagesFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    // create image collection to add multiple pages
                    using (ImageCollection imageCollection = new ImageCollection())
                    {
                        try
                        {
                            foreach (string fileName in openAllImagesFileDialog.FileNames)
                            {
                                imageCollection.Add(fileName);
                            }

                            // show a form that allows to specify encoder settings
                            using (TiffEncoderSettingsForm dlg = new TiffEncoderSettingsForm())
                            {
                                dlg.CanAddImagesToExistingFile = false;
                                dlg.EncoderSettings = _tiffFile.Pages.EncoderSettings;
                                if (dlg.ShowDialog() == DialogResult.OK)
                                {
                                    // create progress controller
                                    IProgressController progressController = new ProgressControllerWithDelegates(ImagesEncodingProgress, ImageEncodingProgress);

                                    // insert pages
                                    _tiffFile.Pages.Insert(pageIndex, imageCollection, progressController);
                                }
                                else
                                {
                                    // set selected page index as current
                                    pageIndex = viewerToolStrip.SelectedPageIndex;
                                }
                            }
                        }
                        finally
                        {
                            imageCollection.ClearAndDisposeItems();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pageIndex = viewerToolStrip.SelectedPageIndex;
                }

                // update page count after TIFF file is changed
                UpdatePageCount();

                SetCurrentPageIndex(pageIndex);
            }

            IsTiffFileLocked = false;
        }

        /// <summary>
        /// Updates the progress bar not safely.
        /// </summary>
        /// <param name="progress">The amount of progress.</param>
        void UpdateLoadingProgressBar(int progress)
        {
            imageLoadingProgressBarLabel.Visible = progress != 100;
            imageLoadingProgressBar.Visible = progress != 100;
            imageLoadingProgressBar.Value = progress;

            statusStrip1.Update();
        }

        /// <summary>
        /// The callback method for image loading progress.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ProgressEventArgs"/> instance containing the event data.</param>
        private void ImageLoadingProgress(object sender, ProgressEventArgs e)
        {
            int progress = e.Progress;
            if (InvokeRequired)
                Invoke(new InvokeUpdateProgressBarDelegate(UpdateLoadingProgressBar), progress);
            else
                UpdateLoadingProgressBar(progress);
        }

        /// <summary>
        /// The callback method for images encoding progress.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ProgressEventArgs"/> instance containing the event data.</param>
        private void ImagesEncodingProgress(object sender, ProgressEventArgs e)
        {
            imagesEncodingProgressBarLabel.Visible = e.Progress != 100;
            imagesEncodingProgressBar.Visible = e.Progress != 100;
            imagesEncodingProgressBar.Value = e.Progress;

            statusStrip1.Update();
        }

        /// <summary>
        /// The callback method for image encoding progress.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ProgressEventArgs"/> instance containing the event data.</param>
        private void ImageEncodingProgress(object sender, ProgressEventArgs e)
        {
            imageEncodingProgressBarLabel.Visible = e.Progress != 100;
            imageEncodingProgressBar.Visible = e.Progress != 100;
            imageEncodingProgressBar.Value = e.Progress;

            statusStrip1.Update();
        }

        #endregion



        #region Delegates

        /// <summary>
        /// Represents the method that updates the progress bar.
        /// </summary>
        delegate void InvokeUpdateProgressBarDelegate(int progress);

        #endregion

    }
}
