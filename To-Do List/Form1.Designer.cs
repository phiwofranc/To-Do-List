namespace To_Do_List
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdd = new Button();
            buttonDelete = new Button();
            textBoxItem = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(24, 318);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(97, 31);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(176, 318);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(97, 31);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // textBoxItem
            // 
            textBoxItem.Location = new Point(24, 289);
            textBoxItem.Name = "textBoxItem";
            textBoxItem.Size = new Size(256, 23);
            textBoxItem.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 375);
            Controls.Add(label1);
            Controls.Add(textBoxItem);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Name = "Form1";
            Text = "To-Do List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Button buttonDelete;
        private TextBox textBoxItem;
        private Label label1;
    }
}