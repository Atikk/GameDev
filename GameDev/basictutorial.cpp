//ABCDEFGIJKLMNOPQRSTUVWXYZ
//abcdefghijklmnopqrstuvwxyz
//123456789-0
#include <iostream>
using namespace std;
//        z['a'] = 1; z['b'] = 2;z['c'] = 3;z['d'] = 4; z['e'] = 5; z['f'] = 6;
//        z['g'] = 7; z['h'] = 8;z['i'] = 9;z['j'] = 15;z['k'] =11;
//        z['l'] = 22;z['m']=33;z['n']=44;z['o']=55;z['p']=66;
//        z['q'] = 77; z['r']=88;z['s']=151;z['t']=141;z['u']=131;z['v']=121;
//        z['w'] = 111;
//these are my input and output variables
//float y = .66;
//float x = .23;
//bool z = true;

class Globals{
    public:
        //takes x and returns Y with Dimension, Action, and Property.
        string init(string x){
            //akw = 1.11.111
            //Input,Reverse,Wait.
            if(x == "a"){string y = "[A]"; return y;}
            if(x == "k"){string y = "[A,A]";return y;}
            if(x == "w"){string y = "[A,A,A]";return y;}
            //Slow,Ground,Drop - Gravity
            if(x == "b"){string y = "[B]";return y;}
            else if(x == "l"){string y = "[B,B]";return y;}
            else if(x == "v"){string y = "[A,B,A]";return y;}
            //Change,Move,Use - Energy
            else if(x == "c"){string y = "[C]";return y;}
            else if(x == "m"){string y = "[C,C]";return y;}
            else if(x == "u"){string y = "[A,C,A]";return y;}
            //Area,String,Cast -Space
            else if(x == "d"){string y = "[D]";return y;}
            else if(x == "n"){string y = "[D,D]";return y;}
            else if(x == "t"){string y = "[A,D,A]";return y;}
            //Play,Pause,Loop,Start -Time
            else if(x == "e"){string y = "[E]";return y;}
            else if(x == "j"){string y = "[A,A,E]";return y;}
            else if(x == "o"){string y = "[E,E]";return y;}
            else if(x == "s"){string y = "[A,E,A]";return y;}
            //Warn,Inspect,End - Gates
            else if(x == "f"){string y = "[F]";return y;}
            else if(x == "i"){string y = "[I]";return y;}
            else if(x == "p"){string y = "[F,F]";return y;}
            //Lift Raise Hold - Volume
            else if(x == "g"){string y = "[G]";return y;}
            else if(x == "q"){string y = "[G,G]";return y;}

            else if(x == "h"){string y = "[H]";return y;}
            else if(x == "r"){string y = "[HH]";return y;}
            else{string y = "";
                return y;
            }

        }
    private:
};

//global library
int second;
int tick;
int selected_obj;
int unit_obj;
string name;

//takes value; return nothing//
void destroy_string(string kwargs){
  kwargs = "";
}
void destroy_int(int kwargs){
  kwargs = NULL;
}

class A{
    public:
        class create{
            //takes seconds; returns nothing//
            int a_timer(int seconds){
                int timer;
                timer = seconds;
                while(timer > 0){
                    timer = timer - second;
                    return tick;
                }
                destroy_int(timer);

            };
            //takes nothing //returns Unit
            string new_unit(){

                string createdUnit="";
                string input="";
                cout<<"creating unit.. \n ";
                cout<<"unitName :"<<endl;
                getline(cin,input);
                createdUnit = "unitName : " + input + "\n";
                cout<<"unitClass : "<<endl;
                getline(cin,input);
                createdUnit = createdUnit + "unitClass : " + input + "\n";
                cout<<"unitHealth : "<<endl;
                getline(cin,input);
                createdUnit = createdUnit + "unitHealth : " + input + "\n";
                cout<<"unitAttackType : "<<endl;
                getline(cin,input);
                createdUnit = createdUnit + "unitAttackType : " + input + "\n";
                cout<<"unitAttackDamage : "<<endl;
                getline(cin,input);
                createdUnit = createdUnit + "unitAttackDamage : " + input + "\n";
                cout<<"unitArmorType : "<<endl;
                getline(cin,input);
                createdUnit = createdUnit + "unitAttackType : " + input + "\n";
                cout<<"unitArmorStr : "<<endl;
                getline(cin,input);
                createdUnit = createdUnit + "unitArmorStr :" + input + "\n";
                cout<<" \n \n \n";
                cout<<"unit has been created! \n";
                cout<<createdUnit;
                string Unit = createdUnit;
                string destroy_string(createdUnit);
                return Unit;
                }
            //takes nothing // returns Unit//
            public:
            //takes nothing // returns Unit//
            string a_unit(){
                if(selected_obj == unit_obj){
                    return new_unit();
                }
                else{
                    cout<<"the selected object is not a unit";
                };


            };

        };
};
int main(){
    Globals z;
    string input = "";

    cout<<"Initializing... \n";
    cout<<"Main Menu \n \n";
    cout<<"press 1 to iterate through keymap. \n";
    cout<<"press 2 to create a unit \n";
    getline(cin,input);
    string answer = input;
    if(answer=="2"){
      A::create mk;
      string mkUnit = mk.a_unit();
    }
    while(answer == "1") {
      cout<<"Iterating through main keymap... \n";
      cout<<"Please enter 1 char..";
      cout<<"Press 0 to quit.. \n";

      getline(cin,input);
      if(input == "0"){
        answer == "";
        return main();
      }

      string x = input;

      cout<< x << endl;

      string y = z.init(x);

      int clock = 10;
      int bit = 20;
      //this is white space
      while(bit > 0){
        cout<<" ";
        bit--;
      }
      while(clock>0){
        cout<<y<<endl;
        clock--;
      }
    }

    cout<<" \n \n \n";
    cout<<"would you like to continue? \n Enter any key to cont.. Enter n or q to exit... \n";
    getline(cin,input);

    answer = input;
    if(answer=="n" or answer=="q"){
    }
    else{
      cout<<"key invalid \n";
      main();
      return 0;
    }
}
