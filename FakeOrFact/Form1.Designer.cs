namespace FakeOrFact;

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
        components = new System.ComponentModel.Container();
        cbxCategoria = new ComboBox();
        btnIniciar = new Button();
        lblPergunta = new Label();
        btnFake = new Button();
        btnFact = new Button();
        lblExplicacao = new Label();
        lblPontuacao = new Label();
        lblProgresso = new Label();

        SuspendLayout();

        // Criação do elemento cbxCategoria no Form
        cbxCategoria.Location = new.System.Drawing.Point(20, 20);
        cbxCategoria.Size = new.System.Drawing.Size(200, 28);
        cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);

        // Criação do elemento de botão btnIniciar
        btnIniciar.Location = new System.Drawing.Point(100, 32);
        btnIniciar.Text = "Iniciar";
        btnIniciar.Font = new System.Drawing.Font("Segoe UI", 10F);
        btnIniciar.BackColor = System.Drawing.Color.SteelBlue;
        btnIniciar.ForeColor = System.Drawing.Color.White;
        btnIniciar.FlatStyle = FlatStyle.Flat;
        btnIniciar_Click += new EventHandler(btnIniciar_Click);

        // Criação do elemento de label Pontuação
        lblPontuacao.Location = new System.Drawing.Point(560, 22);
        lblPontuacao.Size = new System.Drawing.Size(200, 28);
        lblPontuacao.Text = "Pontuação: 0";
        lblPontuacao.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPontuacao.ForeColor = System.Drawing.Color.Gray;

        // Criação do elemento de label do Progresso
        lblProgresso.Location = new System.Drawing.Point(20, 65);
        lblProgresso.Size = new System.Drawing.Size(740, 25);
        lblProgresso.Text = "Pergunta 0 de 0";
        lblProgresso.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblProgresso.ForeColor = System.Drawing.Color.Gray;

        // Criação do elemento label de Pergunta
        lblPergunta.Location = new System.Drawing.Point(10, 100);
        lblPergunta.Size = new System.Drawing.Size(740, 120);
        lblPergunta.Text = "Selecione uma categoria e clique em Iniciar!";
        lblPergunta.Font = new System.Drawing.Font("Segoe UI", 13F);
        lblPergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // Criação do elemento de botão FAKE
        btnFake.Location = new System.Drawing.Point(120, 240);
        btnFake.Size = new System.Drawing.Size(200, 55);
        btnFake.Text = "❌ FAKE";
        btnFake.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        btnFake.BackColor = System.Drawing.Color.IndianRed;
        btnFake.ForeColor = System.Drawing.Color.White;
        btnFake.FlatSyle = FlatStyle.Flat;
        btnFake.Enabled = false;
        btnFake_Click += new EventHandler(btnFake_Click);

        btnFact.Location = new System.Drawing.Point(460, 240);
        btnFact.Size = new System.Drawing.Size(200, 55);
        btnFact.Text = "✅ FACT";
        btnFact.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        btnFact.BackColor = System.Drawing.Color.SeaGreen;
        btnFact.ForeColor = System.Drawing.Color.White;
        btnFact.FlatSyle = FlatStyle.Flat;
        btnFact_Click += new EventHandler(btnFact_Click);

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Text = "Form1";
    }

    #endregion
}