using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagment.Models
{
    internal class EnableDisableControlClass
    {

        public static void DisableGroupControl(GroupControl GroupControlName)
        {
            try
            {
                foreach (Control CTRL in GroupControlName.Controls)
                {

                    if (CTRL is LookUpEdit)
                    {
                        ((LookUpEdit)CTRL).Properties.ReadOnly = true;
                    }
                    if (CTRL is CheckEdit)
                    {
                        ((CheckEdit)CTRL).Properties.ReadOnly = true;
                    }
                    if (CTRL is SearchLookUpEdit)
                    {
                        ((SearchLookUpEdit)CTRL).Properties.ReadOnly = true;
                    }
                    else if (CTRL is TextEdit)
                    {
                        ((TextEdit)CTRL).Properties.ReadOnly = true;
                    }
                    else if (CTRL is DateEdit)
                    {
                        ((DateEdit)CTRL).Properties.ReadOnly = true;
                    }
                    else if (CTRL is SimpleButton)
                    {
                        ((SimpleButton)CTRL).Enabled = false;
                    }
                    else if (CTRL is ListBoxControl)
                    {
                        ((ListBoxControl)CTRL).Enabled = false;
                    }
                    else if (CTRL is RadioGroup)
                    {
                        ((RadioGroup)CTRL).ReadOnly = true;
                    }
                    else if (CTRL is GridControl)
                    {
                        GridView view = ((GridControl)CTRL).MainView as GridView;
                        view.OptionsBehavior.Editable = false;
                    }

                    else if (CTRL is ToggleSwitch)
                    {
                        ((ToggleSwitch)CTRL).ReadOnly = true;
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        public static void EnableGroupControl(GroupControl GroupControlName)
        {
            try
            {
                foreach (Control CTRL in GroupControlName.Controls)
                {

                    if (CTRL is LookUpEdit)
                    {
                        ((LookUpEdit)CTRL).Properties.ReadOnly = false;
                    }
                    if (CTRL is CheckEdit)
                    {
                        ((CheckEdit)CTRL).Properties.ReadOnly = false;
                    }
                    if (CTRL is SearchLookUpEdit)
                    {
                        ((SearchLookUpEdit)CTRL).Properties.ReadOnly = false;
                    }
                    else if (CTRL is TextEdit)
                    {
                        ((TextEdit)CTRL).Properties.ReadOnly = false;
                    }
                    else if (CTRL is DateEdit)
                    {
                        ((DateEdit)CTRL).Properties.ReadOnly = false;
                    }
                    else if (CTRL is SimpleButton)
                    {
                        ((SimpleButton)CTRL).Enabled = true;
                    }
                    else if (CTRL is ListBoxControl)
                    {
                        ((ListBoxControl)CTRL).Enabled = true;
                    }
                    else if (CTRL is RadioGroup)
                    {
                        ((RadioGroup)CTRL).ReadOnly = false;
                    }

                    else if (CTRL is GridControl)
                    {
                        GridView view = ((GridControl)CTRL).MainView as GridView;
                        view.OptionsBehavior.Editable = true;
                    }

                    else if (CTRL is ToggleSwitch)
                    {
                        ((ToggleSwitch)CTRL).ReadOnly = false;
                    }



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        public static void DisableScrollControl(XtraScrollableControl ScrollableGroupcontrolName)
        {
            try
            {
                foreach (Control CTRL in ScrollableGroupcontrolName.Controls)
                {

                    if (CTRL is LookUpEdit)
                    {
                        ((LookUpEdit)CTRL).Properties.ReadOnly = true;
                    }
                    if (CTRL is CheckEdit)
                    {
                        ((CheckEdit)CTRL).Properties.ReadOnly = true;
                    }
                    if (CTRL is SearchLookUpEdit)
                    {
                        ((SearchLookUpEdit)CTRL).Properties.ReadOnly = true;
                    }
                    else if (CTRL is TextEdit)
                    {
                        ((TextEdit)CTRL).Properties.ReadOnly = true;
                    }
                    else if (CTRL is DateEdit)
                    {
                        ((DateEdit)CTRL).Properties.ReadOnly = true;
                    }
                    else if (CTRL is SimpleButton)
                    {
                        ((SimpleButton)CTRL).Enabled = false;
                    }
                    else if (CTRL is ListBoxControl)
                    {
                        ((ListBoxControl)CTRL).Enabled = false;
                    }
                    else if (CTRL is RadioGroup)
                    {
                        ((RadioGroup)CTRL).ReadOnly = true;
                    }
                    else if (CTRL is ToggleSwitch)
                    {
                        ((ToggleSwitch)CTRL).ReadOnly = true;
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        public static void EnableScrollControl(XtraScrollableControl ScrollableGroupControlName)
        {
            try
            {
                foreach (Control CTRL in ScrollableGroupControlName.Controls)
                {

                    if (CTRL is LookUpEdit)
                    {
                        ((LookUpEdit)CTRL).Properties.ReadOnly = false;
                    }
                    if (CTRL is CheckEdit)
                    {
                        ((CheckEdit)CTRL).Properties.ReadOnly = false;
                    }
                    if (CTRL is SearchLookUpEdit)
                    {
                        ((SearchLookUpEdit)CTRL).Properties.ReadOnly = false;
                    }
                    else if (CTRL is TextEdit)
                    {
                        ((TextEdit)CTRL).Properties.ReadOnly = false;
                    }
                    else if (CTRL is DateEdit)
                    {
                        ((DateEdit)CTRL).Properties.ReadOnly = false;
                    }
                    else if (CTRL is SimpleButton)
                    {
                        ((SimpleButton)CTRL).Enabled = true;
                    }
                    else if (CTRL is ListBoxControl)
                    {
                        ((ListBoxControl)CTRL).Enabled = true;
                    }
                    else if (CTRL is RadioGroup)
                    {
                        ((RadioGroup)CTRL).ReadOnly = false;
                    }



                    else if (CTRL is ToggleSwitch)
                    {
                        ((ToggleSwitch)CTRL).ReadOnly = false;
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        public static void EnablePanelControl(PanelControl PanelControlName)
        {
            try
            {
                foreach (Control CTRL in PanelControlName.Controls)
                {

                    if (CTRL is LookUpEdit)
                    {
                        ((LookUpEdit)CTRL).Properties.ReadOnly = false;
                    }
                    if (CTRL is CheckEdit)
                    {
                        ((CheckEdit)CTRL).Properties.ReadOnly = false;
                    }
                    if (CTRL is SearchLookUpEdit)
                    {
                        ((SearchLookUpEdit)CTRL).Properties.ReadOnly = false;
                    }
                    else if (CTRL is TextEdit)
                    {
                        ((TextEdit)CTRL).Properties.ReadOnly = false;
                    }
                    else if (CTRL is DateEdit)
                    {
                        ((DateEdit)CTRL).Properties.ReadOnly = false;
                    }
                    else if (CTRL is SimpleButton)
                    {
                        ((SimpleButton)CTRL).Enabled = true;
                    }
                    else if (CTRL is ListBoxControl)
                    {
                        ((ListBoxControl)CTRL).Enabled = true;
                    }
                    else if (CTRL is RadioGroup)
                    {
                        ((RadioGroup)CTRL).ReadOnly = false;
                    }

                    else if (CTRL is GridControl)
                    {
                        GridView view = ((GridControl)CTRL).MainView as GridView;
                        view.OptionsBehavior.Editable = true;
                    }
                    else if (CTRL is PictureEdit)
                    {
                        ((PictureEdit)CTRL).ReadOnly = false;

                    }
                    else if (CTRL is ToggleSwitch)
                    {
                        ((ToggleSwitch)CTRL).ReadOnly = false;
                    }



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        public static void DisablePanelControl(PanelControl PanelControlName)
        {
            try
            {
                foreach (Control CTRL in PanelControlName.Controls)
                {

                    if (CTRL is LookUpEdit)
                    {
                        ((LookUpEdit)CTRL).Properties.ReadOnly = true;
                    }
                    if (CTRL is CheckEdit)
                    {
                        ((CheckEdit)CTRL).Properties.ReadOnly = true;
                    }
                    if (CTRL is SearchLookUpEdit)
                    {
                        ((SearchLookUpEdit)CTRL).Properties.ReadOnly = true;
                    }
                    else if (CTRL is TextEdit)
                    {
                        ((TextEdit)CTRL).Properties.ReadOnly = true;
                    }
                    else if (CTRL is DateEdit)
                    {
                        ((DateEdit)CTRL).Properties.ReadOnly = true;
                    }
                    else if (CTRL is SimpleButton)
                    {
                        ((SimpleButton)CTRL).Enabled = false;
                    }
                    else if (CTRL is ListBoxControl)
                    {
                        ((ListBoxControl)CTRL).Enabled = false;
                    }
                    else if (CTRL is RadioGroup)
                    {
                        ((RadioGroup)CTRL).ReadOnly = true;
                    }
                    else if (CTRL is GridControl)
                    {
                        GridView view = ((GridControl)CTRL).MainView as GridView;
                        view.OptionsBehavior.Editable = false;
                    }
                    else if (CTRL is PictureEdit)
                    {
                        ((PictureEdit)CTRL).ReadOnly = true;

                    }

                    else if (CTRL is ToggleSwitch)
                    {
                        ((ToggleSwitch)CTRL).ReadOnly = false;
                    }



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public static void ClearGroupControl(GroupControl groupcontrol)
        {
            try
            {
                foreach (Control CTRL in groupcontrol.Controls)
                {

                    if (CTRL is LookUpEdit)
                    {
                        ((LookUpEdit)CTRL).EditValue = -1;
                    }
                    if (CTRL is CheckEdit)
                    {
                        ((CheckEdit)CTRL).Checked = false;
                    }
                    if (CTRL is SearchLookUpEdit)
                    {
                        ((SearchLookUpEdit)CTRL).EditValue = -1;
                    }
                    else if (CTRL is TextEdit)
                    {
                        ((TextEdit)CTRL).Text = "";
                    }
                    else if (CTRL is DateEdit)
                    {
                        ((DateEdit)CTRL).Text = "";
                    }

                    else if (CTRL is GridControl)
                    {
                        GridView view = ((GridControl)CTRL).MainView as GridView;
                        view.OptionsBehavior.Editable = false;
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

    }
}