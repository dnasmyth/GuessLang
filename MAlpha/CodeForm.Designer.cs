namespace MAlpha
{
    partial class CodeForm
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.decodeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.codedTextMemo = new DevExpress.XtraEditors.MemoEdit();
            this.FreqListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.teAnswer = new DevExpress.XtraEditors.TextEdit();
            this.listBoxSpanish = new DevExpress.XtraEditors.ListBoxControl();
            this.teSpan = new DevExpress.XtraEditors.TextEdit();
            this.teEng = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codedTextMemo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreqListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAnswer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSpanish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSpan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEng.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1237, 143);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // decodeBtn
            // 
            this.decodeBtn.Location = new System.Drawing.Point(86, 181);
            this.decodeBtn.Name = "decodeBtn";
            this.decodeBtn.Size = new System.Drawing.Size(75, 23);
            this.decodeBtn.TabIndex = 1;
            this.decodeBtn.Text = "Guess Lang";
            this.decodeBtn.Click += new System.EventHandler(this.decodeBtn_Click);
            // 
            // codedTextMemo
            // 
            this.codedTextMemo.Location = new System.Drawing.Point(48, 210);
            this.codedTextMemo.MenuManager = this.ribbonControl1;
            this.codedTextMemo.Name = "codedTextMemo";
            this.codedTextMemo.Size = new System.Drawing.Size(675, 142);
            this.codedTextMemo.TabIndex = 2;
            // 
            // FreqListBox
            // 
            this.FreqListBox.Location = new System.Drawing.Point(126, 358);
            this.FreqListBox.MultiColumn = true;
            this.FreqListBox.Name = "FreqListBox";
            this.FreqListBox.Size = new System.Drawing.Size(416, 549);
            this.FreqListBox.TabIndex = 3;
            // 
            // teAnswer
            // 
            this.teAnswer.Location = new System.Drawing.Point(824, 221);
            this.teAnswer.MenuManager = this.ribbonControl1;
            this.teAnswer.Name = "teAnswer";
            this.teAnswer.Size = new System.Drawing.Size(170, 20);
            this.teAnswer.TabIndex = 5;
            // 
            // listBoxSpanish
            // 
            this.listBoxSpanish.Location = new System.Drawing.Point(613, 369);
            this.listBoxSpanish.Name = "listBoxSpanish";
            this.listBoxSpanish.Size = new System.Drawing.Size(465, 538);
            this.listBoxSpanish.TabIndex = 6;
            // 
            // teSpan
            // 
            this.teSpan.Location = new System.Drawing.Point(824, 266);
            this.teSpan.MenuManager = this.ribbonControl1;
            this.teSpan.Name = "teSpan";
            this.teSpan.Size = new System.Drawing.Size(100, 20);
            this.teSpan.TabIndex = 7;
            // 
            // teEng
            // 
            this.teEng.Location = new System.Drawing.Point(824, 302);
            this.teEng.MenuManager = this.ribbonControl1;
            this.teEng.Name = "teEng";
            this.teEng.Size = new System.Drawing.Size(100, 20);
            this.teEng.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(968, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "English";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(971, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Spanish";
            // 
            // CodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 919);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teEng);
            this.Controls.Add(this.teSpan);
            this.Controls.Add(this.listBoxSpanish);
            this.Controls.Add(this.teAnswer);
            this.Controls.Add(this.FreqListBox);
            this.Controls.Add(this.codedTextMemo);
            this.Controls.Add(this.decodeBtn);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "CodeForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Mono Alpha";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codedTextMemo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreqListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAnswer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSpanish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSpan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEng.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.SimpleButton decodeBtn;
        private DevExpress.XtraEditors.MemoEdit codedTextMemo;
        private DevExpress.XtraEditors.ListBoxControl FreqListBox;
        private DevExpress.XtraEditors.TextEdit teAnswer;
        private DevExpress.XtraEditors.ListBoxControl listBoxSpanish;
        private DevExpress.XtraEditors.TextEdit teSpan;
        private DevExpress.XtraEditors.TextEdit teEng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

