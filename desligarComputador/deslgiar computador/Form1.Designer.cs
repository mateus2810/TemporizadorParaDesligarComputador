
namespace deslgiar_computador
{
    partial class Temporizador
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
            this.Desligar = new System.Windows.Forms.Button();
            this.DesativarDesligamento = new System.Windows.Forms.Button();
            this.ListagemTempo = new System.Windows.Forms.ComboBox();
            this.TextoTempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Desligar
            // 
            this.Desligar.Location = new System.Drawing.Point(269, 40);
            this.Desligar.Name = "Desligar";
            this.Desligar.Size = new System.Drawing.Size(137, 51);
            this.Desligar.TabIndex = 0;
            this.Desligar.Text = "Desligar Computador";
            this.Desligar.UseVisualStyleBackColor = true;
            this.Desligar.Click += new System.EventHandler(this.Desligar_Click);
            // 
            // DesativarDesligamento
            // 
            this.DesativarDesligamento.Location = new System.Drawing.Point(269, 108);
            this.DesativarDesligamento.Name = "DesativarDesligamento";
            this.DesativarDesligamento.Size = new System.Drawing.Size(137, 43);
            this.DesativarDesligamento.TabIndex = 1;
            this.DesativarDesligamento.Text = "Desativar Desligamento";
            this.DesativarDesligamento.UseVisualStyleBackColor = true;
            this.DesativarDesligamento.Click += new System.EventHandler(this.DesativarDesligamento_Click);
            // 
            // ListagemTempo
            // 
            this.ListagemTempo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListagemTempo.FormattingEnabled = true;
            this.ListagemTempo.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60\t"});
            this.ListagemTempo.Location = new System.Drawing.Point(31, 80);
            this.ListagemTempo.Name = "ListagemTempo";
            this.ListagemTempo.Size = new System.Drawing.Size(180, 33);
            this.ListagemTempo.TabIndex = 2;
            this.ListagemTempo.SelectedIndexChanged += new System.EventHandler(this.ListagemTempo_SelectedIndexChanged);
            // 
            // TextoTempo
            // 
            this.TextoTempo.AutoSize = true;
            this.TextoTempo.Location = new System.Drawing.Point(31, 40);
            this.TextoTempo.Name = "TextoTempo";
            this.TextoTempo.Size = new System.Drawing.Size(189, 15);
            this.TextoTempo.TabIndex = 3;
            this.TextoTempo.Text = "Deseja desligar em quanto tempo?";
            this.TextoTempo.Click += new System.EventHandler(this.TextoTempo_Click);
            // 
            // Temporizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 217);
            this.Controls.Add(this.ListagemTempo);
            this.Controls.Add(this.TextoTempo);
            this.Controls.Add(this.DesativarDesligamento);
            this.Controls.Add(this.Desligar);
            this.Name = "Temporizador";
            this.Text = "Temporizador Computador";
            this.Load += new System.EventHandler(this.Temporizador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Desligar;
        private System.Windows.Forms.Button DesativarDesligamento;
        private System.Windows.Forms.ComboBox ListagemTempo;
        private System.Windows.Forms.Label TextoTempo;
    }
}

