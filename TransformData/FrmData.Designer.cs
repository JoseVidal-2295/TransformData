namespace TransformData
{
    partial class FrmData
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textOutPut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCondition = new System.Windows.Forms.TextBox();
            this.btnTransform = new System.Windows.Forms.Button();
            this.textCondition2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkUseCondition = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.textCondition3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbCondition1 = new System.Windows.Forms.RadioButton();
            this.rbCondition2 = new System.Windows.Forms.RadioButton();
            this.rbCondition3 = new System.Windows.Forms.RadioButton();
            this.rbCondition4 = new System.Windows.Forms.RadioButton();
            this.textCondition4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(23, 28);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(469, 138);
            this.textInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto de entrada";
            // 
            // textOutPut
            // 
            this.textOutPut.Location = new System.Drawing.Point(23, 188);
            this.textOutPut.Multiline = true;
            this.textOutPut.Name = "textOutPut";
            this.textOutPut.ReadOnly = true;
            this.textOutPut.Size = new System.Drawing.Size(469, 211);
            this.textOutPut.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto de salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Condición 1:";
            // 
            // textCondition
            // 
            this.textCondition.Location = new System.Drawing.Point(328, 413);
            this.textCondition.Name = "textCondition";
            this.textCondition.Size = new System.Drawing.Size(164, 20);
            this.textCondition.TabIndex = 1;
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(23, 494);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(75, 23);
            this.btnTransform.TabIndex = 5;
            this.btnTransform.Text = "Transformar";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // textCondition2
            // 
            this.textCondition2.Location = new System.Drawing.Point(328, 439);
            this.textCondition2.Name = "textCondition2";
            this.textCondition2.Size = new System.Drawing.Size(164, 20);
            this.textCondition2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Condición 2:";
            // 
            // chkUseCondition
            // 
            this.chkUseCondition.AutoSize = true;
            this.chkUseCondition.Location = new System.Drawing.Point(23, 412);
            this.chkUseCondition.Name = "chkUseCondition";
            this.chkUseCondition.Size = new System.Drawing.Size(106, 17);
            this.chkUseCondition.TabIndex = 8;
            this.chkUseCondition.Text = "Usar condición 2";
            this.chkUseCondition.UseVisualStyleBackColor = true;
            this.chkUseCondition.Visible = false;
            this.chkUseCondition.CheckedChanged += new System.EventHandler(this.chkUseCondition_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(127, 494);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textCondition3
            // 
            this.textCondition3.Location = new System.Drawing.Point(328, 465);
            this.textCondition3.Name = "textCondition3";
            this.textCondition3.Size = new System.Drawing.Size(164, 20);
            this.textCondition3.TabIndex = 11;
            this.textCondition3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Condición 3:";
            // 
            // rbCondition1
            // 
            this.rbCondition1.AutoSize = true;
            this.rbCondition1.Location = new System.Drawing.Point(23, 438);
            this.rbCondition1.Name = "rbCondition1";
            this.rbCondition1.Size = new System.Drawing.Size(81, 17);
            this.rbCondition1.TabIndex = 12;
            this.rbCondition1.TabStop = true;
            this.rbCondition1.Text = "Condición 1";
            this.rbCondition1.UseVisualStyleBackColor = true;
            // 
            // rbCondition2
            // 
            this.rbCondition2.AutoSize = true;
            this.rbCondition2.Location = new System.Drawing.Point(23, 464);
            this.rbCondition2.Name = "rbCondition2";
            this.rbCondition2.Size = new System.Drawing.Size(81, 17);
            this.rbCondition2.TabIndex = 13;
            this.rbCondition2.TabStop = true;
            this.rbCondition2.Text = "Condición 2";
            this.rbCondition2.UseVisualStyleBackColor = true;
            // 
            // rbCondition3
            // 
            this.rbCondition3.AutoSize = true;
            this.rbCondition3.Location = new System.Drawing.Point(127, 438);
            this.rbCondition3.Name = "rbCondition3";
            this.rbCondition3.Size = new System.Drawing.Size(81, 17);
            this.rbCondition3.TabIndex = 14;
            this.rbCondition3.TabStop = true;
            this.rbCondition3.Text = "Condición 3";
            this.rbCondition3.UseVisualStyleBackColor = true;
            // 
            // rbCondition4
            // 
            this.rbCondition4.AutoSize = true;
            this.rbCondition4.Location = new System.Drawing.Point(127, 461);
            this.rbCondition4.Name = "rbCondition4";
            this.rbCondition4.Size = new System.Drawing.Size(81, 17);
            this.rbCondition4.TabIndex = 15;
            this.rbCondition4.TabStop = true;
            this.rbCondition4.Text = "Condición 4";
            this.rbCondition4.UseVisualStyleBackColor = true;
            // 
            // textCondition4
            // 
            this.textCondition4.Location = new System.Drawing.Point(328, 491);
            this.textCondition4.Name = "textCondition4";
            this.textCondition4.Size = new System.Drawing.Size(164, 20);
            this.textCondition4.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Condición 4:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 549);
            this.Controls.Add(this.textCondition4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbCondition4);
            this.Controls.Add(this.rbCondition3);
            this.Controls.Add(this.rbCondition2);
            this.Controls.Add(this.rbCondition1);
            this.Controls.Add(this.textCondition3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkUseCondition);
            this.Controls.Add(this.textCondition2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCondition);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textOutPut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textInput);
            this.Name = "Form1";
            this.Text = "Transformar datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOutPut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCondition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.TextBox textCondition2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkUseCondition;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textCondition3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbCondition1;
        private System.Windows.Forms.RadioButton rbCondition2;
        private System.Windows.Forms.RadioButton rbCondition3;
        private System.Windows.Forms.RadioButton rbCondition4;
        private System.Windows.Forms.TextBox textCondition4;
        private System.Windows.Forms.Label label6;
    }
}

