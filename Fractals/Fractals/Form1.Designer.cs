
namespace FractalDrawingApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FractalCanvas = new System.Windows.Forms.PictureBox();
            this.Tree = new System.Windows.Forms.Button();
            this.KochCurve = new System.Windows.Forms.Button();
            this.Serpinskiy = new System.Windows.Forms.Button();
            this.TriangleSerpinskiy = new System.Windows.Forms.Button();
            this.Kantor = new System.Windows.Forms.Button();
            this.Coefficient = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CoefField = new System.Windows.Forms.TrackBar();
            this.Angle1Line = new System.Windows.Forms.TrackBar();
            this.Angle2Line = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.RecursionDepth = new System.Windows.Forms.TrackBar();
            this.KochRecursionTrack = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.TriangleRecursionTrack = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.CantorSpaceBetIter = new System.Windows.Forms.TrackBar();
            this.CantorRecursionTrack = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SerpinskiCarpetRecursionTrack = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FractalCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoefField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Angle1Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Angle2Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecursionDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KochRecursionTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriangleRecursionTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantorSpaceBetIter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantorRecursionTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SerpinskiCarpetRecursionTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // FractalCanvas
            // 
            this.FractalCanvas.BackColor = System.Drawing.Color.White;
            this.FractalCanvas.Location = new System.Drawing.Point(731, 23);
            this.FractalCanvas.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.FractalCanvas.Name = "FractalCanvas";
            this.FractalCanvas.Size = new System.Drawing.Size(839, 963);
            this.FractalCanvas.TabIndex = 2;
            this.FractalCanvas.TabStop = false;
            // 
            // Tree
            // 
            this.Tree.Location = new System.Drawing.Point(51, 135);
            this.Tree.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(126, 45);
            this.Tree.TabIndex = 3;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.Click += new System.EventHandler(this.Tree_Click);
            // 
            // KochCurve
            // 
            this.KochCurve.Location = new System.Drawing.Point(51, 308);
            this.KochCurve.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.KochCurve.Name = "KochCurve";
            this.KochCurve.Size = new System.Drawing.Size(126, 45);
            this.KochCurve.TabIndex = 4;
            this.KochCurve.Text = "KochCurve";
            this.KochCurve.UseVisualStyleBackColor = true;
            this.KochCurve.Click += new System.EventHandler(this.KochCurve_Click);
            // 
            // Serpinskiy
            // 
            this.Serpinskiy.Location = new System.Drawing.Point(50, 438);
            this.Serpinskiy.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Serpinskiy.Name = "Serpinskiy";
            this.Serpinskiy.Size = new System.Drawing.Size(126, 45);
            this.Serpinskiy.TabIndex = 5;
            this.Serpinskiy.Text = "Serpinskiy";
            this.Serpinskiy.UseVisualStyleBackColor = true;
            this.Serpinskiy.Click += new System.EventHandler(this.Serpinskiy_Click);
            // 
            // TriangleSerpinskiy
            // 
            this.TriangleSerpinskiy.Location = new System.Drawing.Point(51, 577);
            this.TriangleSerpinskiy.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TriangleSerpinskiy.Name = "TriangleSerpinskiy";
            this.TriangleSerpinskiy.Size = new System.Drawing.Size(126, 45);
            this.TriangleSerpinskiy.TabIndex = 6;
            this.TriangleSerpinskiy.Text = "Triangle";
            this.TriangleSerpinskiy.UseVisualStyleBackColor = true;
            this.TriangleSerpinskiy.Click += new System.EventHandler(this.TriangleSerpinskiy_Click);
            // 
            // Kantor
            // 
            this.Kantor.Location = new System.Drawing.Point(50, 705);
            this.Kantor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Kantor.Name = "Kantor";
            this.Kantor.Size = new System.Drawing.Size(126, 45);
            this.Kantor.TabIndex = 7;
            this.Kantor.Text = "Cantor";
            this.Kantor.UseVisualStyleBackColor = true;
            this.Kantor.Click += new System.EventHandler(this.Cantor_Click);
            // 
            // Coefficient
            // 
            this.Coefficient.AutoSize = true;
            this.Coefficient.Location = new System.Drawing.Point(226, 135);
            this.Coefficient.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Coefficient.Name = "Coefficient";
            this.Coefficient.Size = new System.Drawing.Size(96, 25);
            this.Coefficient.TabIndex = 11;
            this.Coefficient.Text = "Coefficient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Angle of the 1st line";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Angle of the 2nd line";
            // 
            // CoefField
            // 
            this.CoefField.Location = new System.Drawing.Point(187, 165);
            this.CoefField.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CoefField.Maximum = 5;
            this.CoefField.Minimum = 2;
            this.CoefField.Name = "CoefField";
            this.CoefField.Size = new System.Drawing.Size(173, 69);
            this.CoefField.TabIndex = 14;
            this.CoefField.Value = 2;
            this.CoefField.Scroll += new System.EventHandler(this.CoefField_Scroll);
            // 
            // Angle1Line
            // 
            this.Angle1Line.Location = new System.Drawing.Point(354, 165);
            this.Angle1Line.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Angle1Line.Maximum = 90;
            this.Angle1Line.Minimum = 1;
            this.Angle1Line.Name = "Angle1Line";
            this.Angle1Line.Size = new System.Drawing.Size(173, 69);
            this.Angle1Line.TabIndex = 15;
            this.Angle1Line.Value = 1;
            this.Angle1Line.Scroll += new System.EventHandler(this.Angle1Line_Scroll);
            // 
            // Angle2Line
            // 
            this.Angle2Line.Location = new System.Drawing.Point(549, 165);
            this.Angle2Line.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Angle2Line.Maximum = 90;
            this.Angle2Line.Minimum = 1;
            this.Angle2Line.Name = "Angle2Line";
            this.Angle2Line.Size = new System.Drawing.Size(173, 69);
            this.Angle2Line.TabIndex = 16;
            this.Angle2Line.Value = 1;
            this.Angle2Line.Scroll += new System.EventHandler(this.Angle2Line_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Recursion depth for tree";
            // 
            // RecursionDepth
            // 
            this.RecursionDepth.Location = new System.Drawing.Point(549, 23);
            this.RecursionDepth.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RecursionDepth.Maximum = 12;
            this.RecursionDepth.Minimum = 1;
            this.RecursionDepth.Name = "RecursionDepth";
            this.RecursionDepth.Size = new System.Drawing.Size(173, 69);
            this.RecursionDepth.TabIndex = 18;
            this.RecursionDepth.Value = 1;
            this.RecursionDepth.Scroll += new System.EventHandler(this.RecursionDepthTree_Scroll);
            // 
            // KochRecursionTrack
            // 
            this.KochRecursionTrack.Location = new System.Drawing.Point(187, 308);
            this.KochRecursionTrack.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.KochRecursionTrack.Maximum = 8;
            this.KochRecursionTrack.Minimum = 1;
            this.KochRecursionTrack.Name = "KochRecursionTrack";
            this.KochRecursionTrack.Size = new System.Drawing.Size(173, 69);
            this.KochRecursionTrack.TabIndex = 19;
            this.KochRecursionTrack.Value = 1;
            this.KochRecursionTrack.Scroll += new System.EventHandler(this.KochRecursionTrack_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Recursion depth Koch\'s curve";
            // 
            // TriangleRecursionTrack
            // 
            this.TriangleRecursionTrack.Location = new System.Drawing.Point(187, 577);
            this.TriangleRecursionTrack.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TriangleRecursionTrack.Maximum = 8;
            this.TriangleRecursionTrack.Minimum = 1;
            this.TriangleRecursionTrack.Name = "TriangleRecursionTrack";
            this.TriangleRecursionTrack.Size = new System.Drawing.Size(173, 69);
            this.TriangleRecursionTrack.TabIndex = 21;
            this.TriangleRecursionTrack.Value = 1;
            this.TriangleRecursionTrack.Scroll += new System.EventHandler(this.TriangleRecursionTrack_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 597);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Recursion depth Serpinski triangle";
            // 
            // CantorSpaceBetIter
            // 
            this.CantorSpaceBetIter.Location = new System.Drawing.Point(187, 705);
            this.CantorSpaceBetIter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CantorSpaceBetIter.Maximum = 20;
            this.CantorSpaceBetIter.Minimum = 1;
            this.CantorSpaceBetIter.Name = "CantorSpaceBetIter";
            this.CantorSpaceBetIter.Size = new System.Drawing.Size(173, 69);
            this.CantorSpaceBetIter.TabIndex = 23;
            this.CantorSpaceBetIter.Value = 1;
            this.CantorSpaceBetIter.Scroll += new System.EventHandler(this.CantorSpaceBetIter_Scroll);
            // 
            // CantorRecursionTrack
            // 
            this.CantorRecursionTrack.Location = new System.Drawing.Point(447, 705);
            this.CantorRecursionTrack.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CantorRecursionTrack.Maximum = 8;
            this.CantorRecursionTrack.Minimum = 1;
            this.CantorRecursionTrack.Name = "CantorRecursionTrack";
            this.CantorRecursionTrack.Size = new System.Drawing.Size(173, 69);
            this.CantorRecursionTrack.TabIndex = 24;
            this.CantorRecursionTrack.Value = 1;
            this.CantorRecursionTrack.Scroll += new System.EventHandler(this.CantorRecursionTrack_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 798);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Space between iterations";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 798);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Recursion depth for Cantor set";
            // 
            // SerpinskiCarpetRecursionTrack
            // 
            this.SerpinskiCarpetRecursionTrack.Location = new System.Drawing.Point(187, 438);
            this.SerpinskiCarpetRecursionTrack.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SerpinskiCarpetRecursionTrack.Maximum = 5;
            this.SerpinskiCarpetRecursionTrack.Minimum = 1;
            this.SerpinskiCarpetRecursionTrack.Name = "SerpinskiCarpetRecursionTrack";
            this.SerpinskiCarpetRecursionTrack.Size = new System.Drawing.Size(173, 69);
            this.SerpinskiCarpetRecursionTrack.TabIndex = 27;
            this.SerpinskiCarpetRecursionTrack.Value = 1;
            this.SerpinskiCarpetRecursionTrack.Scroll += new System.EventHandler(this.SerpinskiCarpetRecursionTrack_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 458);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(298, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Recursion depth for Serpinski carpet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 1010);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SerpinskiCarpetRecursionTrack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CantorRecursionTrack);
            this.Controls.Add(this.CantorSpaceBetIter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TriangleRecursionTrack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KochRecursionTrack);
            this.Controls.Add(this.RecursionDepth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Angle2Line);
            this.Controls.Add(this.Angle1Line);
            this.Controls.Add(this.CoefField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Coefficient);
            this.Controls.Add(this.Kantor);
            this.Controls.Add(this.TriangleSerpinskiy);
            this.Controls.Add(this.Serpinskiy);
            this.Controls.Add(this.KochCurve);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.FractalCanvas);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Fractals";
            ((System.ComponentModel.ISupportInitialize)(this.FractalCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoefField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Angle1Line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Angle2Line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecursionDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KochRecursionTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriangleRecursionTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantorSpaceBetIter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantorRecursionTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SerpinskiCarpetRecursionTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox FractalCanvas;
        private System.Windows.Forms.Button Tree;
        private System.Windows.Forms.Button KochCurve;
        private System.Windows.Forms.Button Serpinskiy;
        private System.Windows.Forms.Button TriangleSerpinskiy;
        private System.Windows.Forms.Button Kantor;
        private System.Windows.Forms.Label Coefficient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar CoefField;
        private System.Windows.Forms.TrackBar Angle1Line;
        private System.Windows.Forms.TrackBar Angle2Line;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar RecursionDepth;
        private System.Windows.Forms.TrackBar KochRecursionTrack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar TriangleRecursionTrack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar CantorSpaceBetIter;
        private System.Windows.Forms.TrackBar CantorRecursionTrack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar SerpinskiCarpetRecursionTrack;
        private System.Windows.Forms.Label label8;
    }
}

