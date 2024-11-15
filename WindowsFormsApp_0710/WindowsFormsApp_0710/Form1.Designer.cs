namespace WindowsFormsApp_0710
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlusBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.ExBtn = new System.Windows.Forms.Button();
            this.NaBtn = new System.Windows.Forms.Button();
            this.Firstlbl = new System.Windows.Forms.Label();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.Secondlbl = new System.Windows.Forms.Label();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.Resultlbl = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.Readylbl = new System.Windows.Forms.Label();
            this.Linelbl = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlusBtn
            // 
            this.PlusBtn.Location = new System.Drawing.Point(684, 44);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(75, 23);
            this.PlusBtn.TabIndex = 0;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Location = new System.Drawing.Point(684, 104);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(75, 23);
            this.MinusBtn.TabIndex = 1;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // ExBtn
            // 
            this.ExBtn.Location = new System.Drawing.Point(684, 163);
            this.ExBtn.Name = "ExBtn";
            this.ExBtn.Size = new System.Drawing.Size(75, 23);
            this.ExBtn.TabIndex = 2;
            this.ExBtn.Text = "*";
            this.ExBtn.UseVisualStyleBackColor = true;
            this.ExBtn.Click += new System.EventHandler(this.ExBtn_Click);
            // 
            // NaBtn
            // 
            this.NaBtn.Location = new System.Drawing.Point(684, 221);
            this.NaBtn.Name = "NaBtn";
            this.NaBtn.Size = new System.Drawing.Size(75, 23);
            this.NaBtn.TabIndex = 3;
            this.NaBtn.Text = "/";
            this.NaBtn.UseVisualStyleBackColor = true;
            this.NaBtn.Click += new System.EventHandler(this.NaBtn_Click);
            // 
            // Firstlbl
            // 
            this.Firstlbl.AutoSize = true;
            this.Firstlbl.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Firstlbl.Location = new System.Drawing.Point(98, 46);
            this.Firstlbl.Name = "Firstlbl";
            this.Firstlbl.Size = new System.Drawing.Size(106, 21);
            this.Firstlbl.TabIndex = 4;
            this.Firstlbl.Text = "첫번째 수";
            // 
            // textNum1
            // 
            this.textNum1.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textNum1.Location = new System.Drawing.Point(289, 38);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(340, 39);
            this.textNum1.TabIndex = 5;
            // 
            // Secondlbl
            // 
            this.Secondlbl.AutoSize = true;
            this.Secondlbl.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Secondlbl.Location = new System.Drawing.Point(98, 101);
            this.Secondlbl.Name = "Secondlbl";
            this.Secondlbl.Size = new System.Drawing.Size(106, 21);
            this.Secondlbl.TabIndex = 4;
            this.Secondlbl.Text = "두번째 수";
            // 
            // textNum2
            // 
            this.textNum2.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textNum2.Location = new System.Drawing.Point(289, 93);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(340, 39);
            this.textNum2.TabIndex = 5;
            // 
            // Resultlbl
            // 
            this.Resultlbl.AutoSize = true;
            this.Resultlbl.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Resultlbl.Location = new System.Drawing.Point(135, 254);
            this.Resultlbl.Name = "Resultlbl";
            this.Resultlbl.Size = new System.Drawing.Size(69, 21);
            this.Resultlbl.TabIndex = 4;
            this.Resultlbl.Text = "Result";
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textResult.Location = new System.Drawing.Point(289, 246);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(340, 39);
            this.textResult.TabIndex = 5;
            // 
            // Readylbl
            // 
            this.Readylbl.AutoSize = true;
            this.Readylbl.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Readylbl.Location = new System.Drawing.Point(136, 176);
            this.Readylbl.Name = "Readylbl";
            this.Readylbl.Size = new System.Drawing.Size(68, 21);
            this.Readylbl.TabIndex = 4;
            this.Readylbl.Text = "Ready";
            // 
            // Linelbl
            // 
            this.Linelbl.AutoSize = true;
            this.Linelbl.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Linelbl.Location = new System.Drawing.Point(210, 176);
            this.Linelbl.Name = "Linelbl";
            this.Linelbl.Size = new System.Drawing.Size(430, 21);
            this.Linelbl.TabIndex = 4;
            this.Linelbl.Text = "-----------------------------------";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(684, 285);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.Resultlbl);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.Linelbl);
            this.Controls.Add(this.Readylbl);
            this.Controls.Add(this.Secondlbl);
            this.Controls.Add(this.Firstlbl);
            this.Controls.Add(this.NaBtn);
            this.Controls.Add(this.ExBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.PlusBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button ExBtn;
        private System.Windows.Forms.Button NaBtn;
        private System.Windows.Forms.Label Firstlbl;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.Label Secondlbl;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.Label Resultlbl;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label Readylbl;
        private System.Windows.Forms.Label Linelbl;
        private System.Windows.Forms.Button ClearBtn;
    }
}

