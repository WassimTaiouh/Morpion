namespace morpionGUI;

public partial class Form1 : Form
{

    private Game game;
    public Form1()
    {
        InitializeComponent();
        game= new Game();
    }

    public void restartGame(){
        for(int i=0; i<9;i++){
            tabCases[i].Text="";
        }
        game= new Game();
    }
    private void onCaseClick(object sender, System.EventArgs e){
        Case caseSelected= (Case) sender;

        if(caseSelected.Text.Equals("")){
            caseSelected.Text= game.currentPlayer+"";
            int x= caseSelected.getCoord()[0];
            int y= caseSelected.getCoord()[1];
            game.grid[y, x]= game.currentPlayer;
            if(game.isWin()){
                MessageBox.Show($"{game.currentPlayer} a gagné!");
                restartGame();
            }else if(game.isNull()){
                MessageBox.Show("Match null!!!");
                restartGame();
            }else{
                game.changeCurrentPlayer();
            }
        }

        /*MessageBox.Show($"coord: {caseSelected.getCoord()[0]}, {caseSelected.getCoord()[1]}",
                    "numero "+caseSelected.number, 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);*/
    }
}