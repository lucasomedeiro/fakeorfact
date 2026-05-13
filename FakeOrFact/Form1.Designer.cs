using System.Diagnostics;

namespace FakeOrFact;

partial class Form1 

{ 

    private System.ComponentModel.IContainer components = null; 

  

    protected override void Dispose(bool disposing) 

    { 

        if (disposing && (components != null)) 

            components.Dispose(); 

        base.Dispose(disposing); 

    } 

  

    #region Windows Form Designer generated code 

  

    private void InitializeComponent() 

    { 

        components = new System.ComponentModel.Container(); 

  

        // Declaração dos controles 

        cbxCategoria  = new ComboBox(); 

        btnIniciar    = new Button(); 

        lblPergunta   = new Label(); 

        btnFake       = new Button(); 

        btnFact       = new Button(); 

        lblExplicacao = new Label(); 

        lblPontuacao  = new Label(); 

        lblProgresso  = new Label(); 

  

        SuspendLayout(); 

        // cbxCategoria - ComboBox de categorias 
        cbxCategoria.Location     = new System.Drawing.Point(20, 20); 
        cbxCategoria.Size         = new System.Drawing.Size(200, 28); 
        cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList; 
        cbxCategoria.Font         = new System.Drawing.Font("Segoe UI", 10F); 

        // btnIniciar - Botão iniciar 
        btnIniciar.Location  = new System.Drawing.Point(235, 18); 
        btnIniciar.Size      = new System.Drawing.Size(100, 32); 
        btnIniciar.Text      = "Iniciar"; 
        btnIniciar.Font      = new System.Drawing.Font("Segoe UI", 10F); 
        btnIniciar.BackColor = System.Drawing.Color.SteelBlue; 
        btnIniciar.ForeColor = System.Drawing.Color.White; 
        btnIniciar.FlatStyle = FlatStyle.Flat; 
        btnIniciar.Click    += new EventHandler(btnIniciar_Click); 

        // lblPontuacao - Pontuação 
        lblPontuacao.Location  = new System.Drawing.Point(560, 22); 
        lblPontuacao.Size      = new System.Drawing.Size(200, 28); 
        lblPontuacao.Text      = "Pontuação: 0"; 
        lblPontuacao.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); 
        lblPontuacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight; 

        // lblProgresso - Progresso 
        lblProgresso.Location  = new System.Drawing.Point(20, 65); 
        lblProgresso.Size      = new System.Drawing.Size(740, 25); 
        lblProgresso.Text      = "Pergunta 0 de 0"; 
        lblProgresso.Font      = new System.Drawing.Font("Segoe UI", 9F); 
        lblProgresso.ForeColor = System.Drawing.Color.Gray; 

        // lblPergunta - Enunciado 
        lblPergunta.Location  = new System.Drawing.Point(20, 100); 
        lblPergunta.Size      = new System.Drawing.Size(740, 120); 
        lblPergunta.Text      = "Selecione uma categoria e clique em Iniciar!"; 
        lblPergunta.Font      = new System.Drawing.Font("Segoe UI", 13F); 
        lblPergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; 

  

        // btnFake - Botão FAKE 

        btnFake.Location  = new System.Drawing.Point(120, 240); 
        btnFake.Size      = new System.Drawing.Size(200, 55); 
        btnFake.Text      = "❌ FAKE"; 
        btnFake.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold); 
        btnFake.BackColor = System.Drawing.Color.IndianRed; 
        btnFake.ForeColor = System.Drawing.Color.White; 
        btnFake.FlatStyle = FlatStyle.Flat; 
        btnFake.Enabled   = false; 
        btnFake.Click    += new EventHandler(btnFake_Click); 

  
        // btnFact - Botão FACT 
        btnFact.Location  = new System.Drawing.Point(460, 240); 
        btnFact.Size      = new System.Drawing.Size(200, 55); 
        btnFact.Text      = "✅ FACT"; 
        btnFact.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold); 
        btnFact.BackColor = System.Drawing.Color.SeaGreen; 
        btnFact.ForeColor = System.Drawing.Color.White; 
        btnFact.FlatStyle = FlatStyle.Flat; 
        btnFact.Enabled   = false; 
        btnFact.Click    += new EventHandler(btnFact_Click); 

        // lblExplicacao - Explicação da resposta 
        lblExplicacao.Location  = new System.Drawing.Point(20, 315); 
        lblExplicacao.Size      = new System.Drawing.Size(740, 100); 
        lblExplicacao.Text      = ""; 
        lblExplicacao.Font      = new System.Drawing.Font("Segoe UI", 10F); 
        lblExplicacao.TextAlign = System.Drawing.ContentAlignment.TopCenter; 

  

        // Form1 
        AutoScaleMode = AutoScaleMode.Font; 
        ClientSize    = new System.Drawing.Size(800, 450); 
        Text          = "FakeOrFact"; 
        BackColor = System.Drawing.Color.WhiteSmoke;
        Font = new System.Drawing.Font("Segoe UI", 9F);

        Controls.Add(cbxCategoria);
        Controls.Add(btnIniciar);
        Controls.Add(lblPontuacao);
        Controls.Add(lblProgresso);
        Controls.Add(lblPergunta);
        Controls.Add(btnFake);
        Controls.Add(btnFact);
        Controls.Add(lblExplicacao);

        ResumeLayout(false);
    }

    #endregion

    private ComboBox cbxCategoria;
    private Button btnIniciar;
    private Label lblPergunta;
    private Button btnFake;
    private Button btnFact;
    private Label lblExplicacao;
    private Label lblPontuacao;
    private Label lblProgresso;

}