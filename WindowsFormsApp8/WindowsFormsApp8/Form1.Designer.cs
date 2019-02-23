namespace WindowsFormsApp8
{
    partial class FrmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trv1 = new System.Windows.Forms.TreeView();
            this.lstv1 = new System.Windows.Forms.ListView();
            this.addRoot = new System.Windows.Forms.Button();
            this.addChild = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addChild);
            this.groupBox1.Controls.Add(this.addRoot);
            this.groupBox1.Controls.Add(this.lstv1);
            this.groupBox1.Controls.Add(this.trv1);
            this.groupBox1.Location = new System.Drawing.Point(39, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TreeView & ListView";
            // 
            // trv1
            // 
            this.trv1.Location = new System.Drawing.Point(39, 37);
            this.trv1.Name = "trv1";
            this.trv1.Size = new System.Drawing.Size(243, 211);
            this.trv1.TabIndex = 0;
            // 
            // lstv1
            // 
            this.lstv1.Location = new System.Drawing.Point(321, 37);
            this.lstv1.Name = "lstv1";
            this.lstv1.Size = new System.Drawing.Size(242, 211);
            this.lstv1.TabIndex = 1;
            this.lstv1.UseCompatibleStateImageBehavior = false;
            this.lstv1.View = System.Windows.Forms.View.Details;
            // 
            // addRoot
            // 
            this.addRoot.Location = new System.Drawing.Point(72, 278);
            this.addRoot.Name = "addRoot";
            this.addRoot.Size = new System.Drawing.Size(176, 30);
            this.addRoot.TabIndex = 2;
            this.addRoot.Text = "루트추가";
            this.addRoot.UseVisualStyleBackColor = true;
            this.addRoot.Click += new System.EventHandler(this.addRoot_Click);
            // 
            // addChild
            // 
            this.addChild.Location = new System.Drawing.Point(354, 278);
            this.addChild.Name = "addChild";
            this.addChild.Size = new System.Drawing.Size(176, 30);
            this.addChild.TabIndex = 3;
            this.addChild.Text = "자식추가";
            this.addChild.UseVisualStyleBackColor = true;
            this.addChild.Click += new System.EventHandler(this.addChild_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "TreeView&ListView TEST";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addChild;
        private System.Windows.Forms.Button addRoot;
        private System.Windows.Forms.ListView lstv1;
        private System.Windows.Forms.TreeView trv1;
    }
}

