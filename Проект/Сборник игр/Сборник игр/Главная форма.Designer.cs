
namespace Сборник_игр
{
    partial class MainForm
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
            this.PlayBt = new System.Windows.Forms.Button();
            this.HowPlayBt = new System.Windows.Forms.Button();
            this.ExitBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayBt
            // 
            this.PlayBt.Location = new System.Drawing.Point(185, 51);
            this.PlayBt.Name = "PlayBt";
            this.PlayBt.Size = new System.Drawing.Size(134, 51);
            this.PlayBt.TabIndex = 0;
            this.PlayBt.Text = "Играть";
            this.PlayBt.UseVisualStyleBackColor = true;
            this.PlayBt.Click += new System.EventHandler(this.PlayBt_Click);
            // 
            // HowPlayBt
            // 
            this.HowPlayBt.Location = new System.Drawing.Point(185, 108);
            this.HowPlayBt.Name = "HowPlayBt";
            this.HowPlayBt.Size = new System.Drawing.Size(134, 51);
            this.HowPlayBt.TabIndex = 1;
            this.HowPlayBt.Text = "Как играть?";
            this.HowPlayBt.UseVisualStyleBackColor = true;
            this.HowPlayBt.Click += new System.EventHandler(this.HowPlayBt_Click);
            // 
            // ExitBt
            // 
            this.ExitBt.Location = new System.Drawing.Point(185, 164);
            this.ExitBt.Name = "ExitBt";
            this.ExitBt.Size = new System.Drawing.Size(134, 51);
            this.ExitBt.TabIndex = 2;
            this.ExitBt.Text = "Выход";
            this.ExitBt.UseVisualStyleBackColor = true;
            this.ExitBt.Click += new System.EventHandler(this.ExitBt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 314);
            this.Controls.Add(this.ExitBt);
            this.Controls.Add(this.HowPlayBt);
            this.Controls.Add(this.PlayBt);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayBt;
        private System.Windows.Forms.Button HowPlayBt;
        private System.Windows.Forms.Button ExitBt;
    }
}

