using System;
using System.Windows.Forms;

using Vintasoft.Imaging.Codecs.ImageFiles.Tiff;

namespace MultiPageTiffDemo
{
    /// <summary>
    /// A form that allows to specify settings of the new TIFF file.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class CreateNewFileForm : Form
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewFileForm"/> class.
        /// </summary>
        public CreateNewFileForm()
        {
            InitializeComponent();
        }

        #endregion



        #region Properties

        TiffFileFormat _fileFormat = TiffFileFormat.LittleEndian;
        /// <summary>
        /// Gets the file format.
        /// </summary>
        public TiffFileFormat FileFormat
        {
            get { return _fileFormat; }
        }

        TiffFileVersion _fileVersion = TiffFileVersion.StandardTIFF;
        /// <summary>
        /// Gets the file version.
        /// </summary>
        public TiffFileVersion FileVersion
        {
            get { return _fileVersion; }
        }

        #endregion



        #region Methods

        #region UI

        /// <summary>
        /// Handles the Click event of okButton object.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            if (bigEndianRadioButton.Checked)
                _fileFormat = TiffFileFormat.BigEndian;

            if (bigTiffRadioButton.Checked)
                _fileVersion = TiffFileVersion.BigTIFF;

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        #endregion

        #endregion

    }
}
