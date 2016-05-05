# include<iostream>
# include<stdlib.h>
# include<conio.h>
using namespace std;

class name{
private:
	int a;
public:
	~name(){}
	name(){
	a=0;
	}
	name(int x,int y){
	a=x;
	}
	void seta(int x){
	a=x;
	}
	
	
	int geta(){
	return a;
	}

};
name pass(name obj2){
	//cout<<"output is: "<<obj2.geta()<<endl;
	return obj2; 
}

int main(){
	

	int x,y;
	int i=0;
	cin>>x;
	cin>>y;
	name obj(x,y),obj2,obj3;
	int a;
	//cin>>a;
	//obj.seta(a);
	obj=pass(obj);
	cout<<"output is: "<<obj.geta()<<endl;
	//cin>>a;
	//obj2.seta(a);
	cout<<"out put of second object is: "<<obj2.geta();
	getch();
return 0;
}