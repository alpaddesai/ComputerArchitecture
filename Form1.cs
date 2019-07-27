using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompArchitecture
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void Parent_Load(object sender, EventArgs e)
        {

        }


        private void MenuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FirstTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new ChildA("Trivial Predictor");
            child.MdiParent = this;
            child.Show();

        }

        private void SecondTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
           var child = new Child("Static Predictor ");
            child.MdiParent = this;
            child.Show();
        }

        private void BimodalPredictorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new ChildB("Bimodal Predictor");
            child.MdiParent = this;
            child.Show();
        }

        private void CombinedBranchPredictorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new ChildC("CombinedBranch Predictor");
            child.MdiParent = this;
            child.Show();
        }


        private void AgreePredictorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new ChildE("Agree Predictor");
            child.MdiParent = this;
            child.Show();
        }

        private void TwoLevelAdaptiveBranchPredictorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new ChildF("TwoLevelAdaptive Predictor");
            child.MdiParent = this;
            child.Show();
        }

        private void LocalBranchPredictorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new ChildG("LocalBranch Predictor");
            child.MdiParent = this;
            child.Show();
        }

        private void GlobalBranchPredictorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new ChildH("GlobalBranch Predictor");
            child.MdiParent = this;
            child.Show();


        }

        private void YAGSPredictorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var child = new ChildI("YAGS Predictor");
            child.MdiParent = this;
            child.Show();


        }

        private void SelectorPredictorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new ChildJ("Selector Predictor");
            child.MdiParent = this;
            child.Show();

        }

        private void GSharePredictorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new ChildK("gShare Predictor");
            child.MdiParent = this;
            child.Show();

        }

        private void Pentium4Predictor_Click(object sender, EventArgs e)
        {
            var child = new Pentium4Predictor("Pentium 4 Predictor");
            child.MdiParent = this;
            child.Show();
            
        }

        private void AthalonArchPredictor_Click(object sender, EventArgs e)
        {
            var child = new Form14("Athlon Arch Predictor");
            child.MdiParent = this;
            child.Show(); 
        }

        private void ProcessorModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new ProcessorModel("Processor Model");
            child.MdiParent = this;
            child.Show();
        }

        private void InterfaceDesignModelingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new InterfaceDesignModeling(" Interface Design and Modeling");
            child.MdiParent = this;
            child.Show();
        }
    }
}
