# include<iostream>
# include<stdlib.h>
using namespace std;
class iherit{
public:
	void add(){
		cout<<"baap";
	}
	


};
class derive : public iherit{
public:
	void add(){
		cout<<"bacha: ";
	}
};
int main(){
	derive a;
	a.add();

system("PAUSE");
return 0;
}