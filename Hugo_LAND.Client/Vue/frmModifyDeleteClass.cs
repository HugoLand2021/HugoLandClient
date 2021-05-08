using Hugo_LAND.Client.HugoLandServices;
using Hugo_LAND.Client.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Hugo_LAND.Client.Vue
{
    public partial class frmModifyDeleteClass : Form
    {
        private List<ClassDetailsDTO> classes = new List<ClassDetailsDTO>();
        private ClassServiceClient classServiceClient = new ClassServiceClient();
        private readonly CreateClassValidator createClassValidator;
        private int currentClassIndex = 0;
        public frmModifyDeleteClass()
        {
            InitializeComponent();
            if (InitializeInfo())
            {
                SetAllTextboxes(classes.First());
                createClassValidator = new CreateClassValidator();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifiy_Click(object sender, EventArgs e)
        {
            List<string> errorsStats = VerifyInfo();
            if (errorsStats.Count > 0)
            {
                ClassDetailsDTO newClass = new ClassDetailsDTO()
                {
                    ClassName = nomClasseTextBox.Text,
                    Description = descriptionTextBox.Text,
                    StatBaseStr = 0,
                    StatBaseDex = 0,
                    StatBaseReg = 0,
                    StatBaseVitality = 0
                };
                var result = createClassValidator.Validate(newClass);
                foreach (var item in result.Errors)
                    errorsStats.Add(item.ErrorMessage);

                MessageBox.Show(string.Join("\n", errorsStats), "Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ClassDetailsDTO modifiedClass = new ClassDetailsDTO()
                {
                    Id = int.Parse(idTextBox.Text),
                    ClassName = nomClasseTextBox.Text,
                    Description = descriptionTextBox.Text,
                    StatBaseStr = int.Parse(statBaseStrTextBox.Text),
                    StatBaseDex = int.Parse(statBaseDexTextBox.Text),
                    StatBaseReg = int.Parse(statBaseRegTextBox.Text),
                    StatBaseVitality = int.Parse(statBaseVitaliteTextBox.Text)
                };

                var result = createClassValidator.Validate(modifiedClass);

                if (!result.IsValid)
                {
                    MessageBox.Show(string.Join("\n", result.Errors.ToList()), "Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    bool isSuccess = classServiceClient.SaveClass(modifiedClass);
                    if (isSuccess)
                    {
                        MessageBox.Show("The class has been saved", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
                        InitializeInfo();
                        SetAllTextboxes(classes[currentClassIndex]);
                    }
                    else
                        MessageBox.Show("An error has occured while trying to save the class", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dir = MessageBox.Show("Are you sure you want to delete this class?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            switch (dir)
            {
                case DialogResult.Yes:
                    ClassDetailsDTO deletedClass = new ClassDetailsDTO()
                    {
                        Id = int.Parse(idTextBox.Text),
                    };
                    bool isSuccess = classServiceClient.DeleteClass(deletedClass);
                    if (isSuccess)
                    {
                        InitializeInfo();
                        if (!(classes.Count() == 0))
                        {
                            SetAllTextboxes(classes.First());
                        }
                        currentClassIndex = 0;
                    }
                    else
                        MessageBox.Show("An error has occured while trying to delete the class", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            SetAllTextboxes(classes[0]);
            currentClassIndex = 0;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentClassIndex > 0)
            {
                currentClassIndex--;
                SetAllTextboxes(classes[currentClassIndex]);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentClassIndex < classes.Count() - 1)
            {
                currentClassIndex++;
                SetAllTextboxes(classes[currentClassIndex]);
            }

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentClassIndex = classes.Count() - 1;
            SetAllTextboxes(classes[currentClassIndex]);

        }
        private bool InitializeInfo()
        {
            try
            {
                classes = classServiceClient.GetAllClasses().ToList();
            }
            catch
            {

            }
            if (classes.Count() == 0)
            {
                MessageBox.Show("No classes have been found or a network error has occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnDelete.Enabled = false;
                btnModify.Enabled = false;
                nomClasseTextBox.Enabled = false;
                nomClasseTextBox.Text = "";
                descriptionTextBox.Enabled = false;
                descriptionTextBox.Text = "";
                statBaseDexTextBox.Enabled = false;
                statBaseDexTextBox.Text = "";
                statBaseStrTextBox.Enabled = false;
                statBaseStrTextBox.Text = "";
                statBaseRegTextBox.Enabled = false;
                statBaseRegTextBox.Text = "";
                statBaseVitaliteTextBox.Enabled = false;
                statBaseVitaliteTextBox.Text = "";
                idTextBox.Enabled = false;
                idTextBox.Text = "";
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
                return false;
            }
            return true;
        }

        private void SetAllTextboxes(ClassDetailsDTO currentClass)
        {
            idTextBox.Text = currentClass.Id.ToString();
            nomClasseTextBox.Text = currentClass.ClassName;
            descriptionTextBox.Text = currentClass.Description;
            statBaseStrTextBox.Text = currentClass.StatBaseStr.ToString();
            statBaseDexTextBox.Text = currentClass.StatBaseDex.ToString();
            statBaseRegTextBox.Text = currentClass.StatBaseReg.ToString();
            statBaseVitaliteTextBox.Text = currentClass.StatBaseVitality.ToString();
        }

        private List<string> VerifyInfo()
        {
            List<string> errors = new List<string>();
            //Stats
            int StatStr, StatDex, StaReg, StatVitality;
            bool isNumericStr = int.TryParse(statBaseStrTextBox.Text, out StatStr);
            bool isNumericDex = int.TryParse(statBaseDexTextBox.Text, out StatDex);
            bool isNumericReg = int.TryParse(statBaseRegTextBox.Text, out StaReg);
            bool isNumericVitality = int.TryParse(statBaseVitaliteTextBox.Text, out StatVitality);
            if (!isNumericStr || StatStr < 0 || StatStr > 10)
                errors.Add("Please provide a valid base stat str between(inclusive) 0 and 10.");
            if (!isNumericDex || StatDex < 0 || StatDex > 60)
                errors.Add("Please provide a valid base stat dex between(inclusive) 0 and 60.");
            if (!isNumericReg || StaReg < 0 || StaReg > 5)
                errors.Add("Please provide a valid base stat int between(inclusive) 0 and 5.");
            if (!isNumericVitality || StatVitality < 0 || StatVitality > 200)
                errors.Add("Please provide a valid base stat vitality between(inclusive) 0 and 200.");

            return errors;
        }
    }
}
