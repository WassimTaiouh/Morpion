namespace morpionGUI;

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
    
    private Case[] tabCases= new Case[9];

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 400);
        this.Text = "Morpion";

        TableLayoutPanel tab= new TableLayoutPanel();
        tab.RowCount= 3;
        tab.ColumnCount=3;
        tab.Size= new System.Drawing.Size(400, 400);
        for(int i=0; i<9; i++){
            tabCases[i]= new Case(i);
            tabCases[i].Size=  new System.Drawing.Size(100, 100);
            tabCases[i].Click+= new EventHandler(this.onCaseClick);
            tab.Controls.Add(tabCases[i]);
        }
        this.Controls.Add(tab);
    }

    #endregion
}