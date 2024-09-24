namespace morpionGUI;
class Case:Button
{
    public int number;

    public Case(int n):base(){
        this.number= n;
    }


    public int[] getCoord(){
        int [] coord= new int[2];
        coord[0]= (this.number==0 ||  this.number==3 ||   this.number==6 ) ? 0 :
                    (this.number==1 ||  this.number==4 ||   this.number==7) ? 1 : 2;
        coord[1]= (this.number==0 ||  this.number==1 ||   this.number==2) ? 0 :
                    (this.number==3 ||  this.number==4 ||   this.number==5) ? 1 : 2;

        return coord;
    }

}