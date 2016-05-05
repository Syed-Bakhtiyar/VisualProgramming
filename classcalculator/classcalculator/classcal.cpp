#include<iostream>
#include<stdlib.h>

using namespace std;

class abc{
private:
	int a,b,c;
public:
	void seter(int x, int y){
		a=x;
		b=y;
	}

	int add(){
	c=a+b;
	return c;
	}

	int sub(){
	c=a-b;
	return c;
	}

	int mul(){
	c=a*b;
	return c;
	}

	int div(){
	c=a/b;
	return c;
	}
};

int main(){
	abc c1;
	int a,b,c,d;
	cout<<"1.add 2.sub 3.mul 4.div"<<endl;
	cin>>c;
	if(c==1){
	cin>>a;
	cin>>b;
	c1.seter(a,b);
	c=c1.add();
	cout<<c;
	}

	else if(c==2){
	cin>>a;
	cin>>b;
	c1.seter(a,b);
	c=c1.sub();
	cout<<c;
	
	}

	else if(c==3){
	cin>>a;
	cin>>b;
	c1.seter(a,b);
	c=c1.mul();
	cout<<c;
	
	}

	else if(c==4){
	cin>>a;
	cin>>b;
	c1.seter(a,b);
	c=c1.div();
	cout<<c;
	}else{
	cout<<"ghlat dabayaa bhenchoooo";
	cout<<"nullaaaa sirf 4 choice h bhenchooo";
	}
	system("PAUSE");
return 0;
}