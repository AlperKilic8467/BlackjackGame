namespace BlackJackUI
{
    partial class Formen
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
            this.NewBtn = new System.Windows.Forms.Button();
            this.ShuffleBtn = new System.Windows.Forms.Button();
            this.HitBtn = new System.Windows.Forms.Button();
            this.StandBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NbrOfPlayersTB = new System.Windows.Forms.TextBox();
            this.NbrOfDecksTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BigLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(929, 455);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(114, 36);
            this.NewBtn.TabIndex = 0;
            this.NewBtn.Text = "New Game";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // ShuffleBtn
            // 
            this.ShuffleBtn.Location = new System.Drawing.Point(929, 509);
            this.ShuffleBtn.Name = "ShuffleBtn";
            this.ShuffleBtn.Size = new System.Drawing.Size(114, 36);
            this.ShuffleBtn.TabIndex = 1;
            this.ShuffleBtn.Text = "Shuffle";
            this.ShuffleBtn.UseVisualStyleBackColor = true;
            this.ShuffleBtn.Click += new System.EventHandler(this.ShuffleBtn_Click);
            // 
            // HitBtn
            // 
            this.HitBtn.Location = new System.Drawing.Point(929, 564);
            this.HitBtn.Name = "HitBtn";
            this.HitBtn.Size = new System.Drawing.Size(114, 36);
            this.HitBtn.TabIndex = 2;
            this.HitBtn.Text = "Hit";
            this.HitBtn.UseVisualStyleBackColor = true;
            this.HitBtn.Click += new System.EventHandler(this.HitBtn_Click);
            // 
            // StandBtn
            // 
            this.StandBtn.Location = new System.Drawing.Point(929, 618);
            this.StandBtn.Name = "StandBtn";
            this.StandBtn.Size = new System.Drawing.Size(114, 36);
            this.StandBtn.TabIndex = 3;
            this.StandBtn.Text = "Stand";
            this.StandBtn.UseVisualStyleBackColor = true;
            this.StandBtn.Click += new System.EventHandler(this.StandBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dealer";
            // 
            // NbrOfPlayersTB
            // 
            this.NbrOfPlayersTB.Location = new System.Drawing.Point(912, 363);
            this.NbrOfPlayersTB.Name = "NbrOfPlayersTB";
            this.NbrOfPlayersTB.Size = new System.Drawing.Size(130, 20);
            this.NbrOfPlayersTB.TabIndex = 14;
            // 
            // NbrOfDecksTB
            // 
            this.NbrOfDecksTB.Location = new System.Drawing.Point(912, 405);
            this.NbrOfDecksTB.Name = "NbrOfDecksTB";
            this.NbrOfDecksTB.Size = new System.Drawing.Size(130, 20);
            this.NbrOfDecksTB.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(909, 347);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Number of players";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(909, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Number of decks";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(201, 154);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(666, 469);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // BigLabel
            // 
            this.BigLabel.AutoSize = true;
            this.BigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BigLabel.Location = new System.Drawing.Point(415, 48);
            this.BigLabel.Name = "BigLabel";
            this.BigLabel.Size = new System.Drawing.Size(269, 29);
            this.BigLabel.TabIndex = 19;
            this.BigLabel.Text = "Welcome to Blackjack";
            // 
            // Formen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 677);
            this.Controls.Add(this.BigLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NbrOfDecksTB);
            this.Controls.Add(this.NbrOfPlayersTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StandBtn);
            this.Controls.Add(this.HitBtn);
            this.Controls.Add(this.ShuffleBtn);
            this.Controls.Add(this.NewBtn);
            this.Name = "Formen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button ShuffleBtn;
        private System.Windows.Forms.Button HitBtn;
        private System.Windows.Forms.Button StandBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NbrOfPlayersTB;
        private System.Windows.Forms.TextBox NbrOfDecksTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label BigLabel;
    }
}

