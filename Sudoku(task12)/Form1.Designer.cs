﻿namespace Sudoku_task12_
{
    partial class Form1
{
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
        this.captureBtn = new System.Windows.Forms.Button();
        this.saveStateBtn = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // captureBtn
        // 
        this.captureBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.captureBtn.Location = new System.Drawing.Point(69, 857);
        this.captureBtn.Name = "captureBtn";
        this.captureBtn.Size = new System.Drawing.Size(211, 70);
        this.captureBtn.TabIndex = 0;
        this.captureBtn.Text = "Условие введено";
        this.captureBtn.UseVisualStyleBackColor = true;
        // 
        // saveStateBtn
        // 
        this.saveStateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.saveStateBtn.Location = new System.Drawing.Point(542, 857);
        this.saveStateBtn.Name = "saveStateBtn";
        this.saveStateBtn.Size = new System.Drawing.Size(211, 70);
        this.saveStateBtn.TabIndex = 1;
        this.saveStateBtn.Text = "Сохранить состояние";
        this.saveStateBtn.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(854, 934);
        this.Controls.Add(this.saveStateBtn);
        this.Controls.Add(this.captureBtn);
        this.MaximumSize = new System.Drawing.Size(870, 973);
        this.MinimumSize = new System.Drawing.Size(870, 973);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Sudoku";
        this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button captureBtn;
    private System.Windows.Forms.Button saveStateBtn;
}
}