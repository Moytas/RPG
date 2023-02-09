using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
  public partial class ThiefSkills : Form
  {
    public ThiefSkills()
    {
      InitializeComponent();
      SetInitial();
    }

    void SetInitial()
    {
      PP_Value.Text = "15%";
      OL_Value.Text = "10%";
      FRT_Value.Text = "5%";
      MS_Value.Text = "10%";
      HS_Value.Text = "10%";
      DN_Value.Text = "10%";
      CW_Value.Text = "60%";
      RL_Value.Text = "0%";

    }
  }
}
