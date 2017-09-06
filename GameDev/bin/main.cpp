#include <iostream>

using namespace std;

class guiClass{
    public:
        void init(){
            cout << "initializing..."<<endl;
            cout << "This is the Gui" <<endl;
        }

};

void create(int x){
    cout << "This is an Int-object that I have made "<< x << endl;
}

int chk_objPosition(int x, int y){
    int answer = x + y;
    return answer;
}

////int main(){
//    guiClass gameGui;
//    gameGui.init();
//    create(5);
//    cout << chk_objPosition(300,200)<<endl;
//    cout<<"boy i love animals \n";
//    cout<<"and ham"<<endl;
//    cout<<"boy \n i \n love \n ham \n";
//    return 0;
//}
