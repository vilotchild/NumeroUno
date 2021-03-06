﻿namespace TheRealUno {
  partial class FrmTitle {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.btnStartGame = new System.Windows.Forms.Button();
      this.btnContinueGame = new System.Windows.Forms.Button();
      this.btnQuitGame = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnStartGame
      // 
      this.btnStartGame.BackColor = System.Drawing.Color.Black;
      this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStartGame.ForeColor = System.Drawing.Color.White;
      this.btnStartGame.Location = new System.Drawing.Point(62, 423);
      this.btnStartGame.Name = "btnStartGame";
      this.btnStartGame.Size = new System.Drawing.Size(194, 65);
      this.btnStartGame.TabIndex = 0;
      this.btnStartGame.Text = "Start New Game";
      this.btnStartGame.UseVisualStyleBackColor = false;
      this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
      // 
      // btnContinueGame
      // 
      this.btnContinueGame.BackColor = System.Drawing.Color.Black;
      this.btnContinueGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnContinueGame.ForeColor = System.Drawing.Color.White;
      this.btnContinueGame.Location = new System.Drawing.Point(369, 423);
      this.btnContinueGame.Name = "btnContinueGame";
      this.btnContinueGame.Size = new System.Drawing.Size(194, 65);
      this.btnContinueGame.TabIndex = 1;
      this.btnContinueGame.Text = "Continue Game";
      this.btnContinueGame.UseVisualStyleBackColor = false;
      // 
      // btnQuitGame
      // 
      this.btnQuitGame.BackColor = System.Drawing.Color.Black;
      this.btnQuitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnQuitGame.ForeColor = System.Drawing.Color.White;
      this.btnQuitGame.Location = new System.Drawing.Point(676, 423);
      this.btnQuitGame.Name = "btnQuitGame";
      this.btnQuitGame.Size = new System.Drawing.Size(194, 65);
      this.btnQuitGame.TabIndex = 2;
      this.btnQuitGame.Text = "Quit Game";
      this.btnQuitGame.UseVisualStyleBackColor = false;
      this.btnQuitGame.Click += new System.EventHandler(this.btnQuitGame_Click);
      // 
      // FrmTitle
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::TheRealUno.Properties.Resources.title_bg;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(937, 557);
      this.Controls.Add(this.btnQuitGame);
      this.Controls.Add(this.btnContinueGame);
      this.Controls.Add(this.btnStartGame);
      this.DoubleBuffered = true;
      this.Name = "FrmTitle";
      this.Text = "UNO!";
      this.Load += new System.EventHandler(this.FrmTitle_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnStartGame;
    private System.Windows.Forms.Button btnContinueGame;
    private System.Windows.Forms.Button btnQuitGame;
  }
}

