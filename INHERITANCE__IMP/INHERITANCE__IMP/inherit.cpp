# include<iostream>
# include<conio.h>
# include<stdlib.h>
# include<string>
using namespace std;
class parent{
private:
	string name;
	float price;
public:
	void getData(void){
	getline(cin,name);
	cin>>price;
	}
	void putData(void){
	cout<<name<<endl;
	cout<<price;
	}
};
class book : public parent{
private:
	int count;
public:
	void getData(){
	cin>>count;
	}
	void putData(){
	cout<<count;
	}
};
class tape : public parent{
private:
	float record;
public:
	void getData(void){
		cin>>record;
	}
	void putData(void){
	cout<<record;
	}

};
int main(){
	parent cpy1;
	book cpy2;
	tape cpy3;
	cout<<"enter parent:\n";
	cpy1.getData();
	cpy1.putData();
	cout<<"\nenter book\n";
	cpy2.getData();
	cpy2.putData();
	cout<<"\nenter tape\n";
	cpy3.getData();
	cpy3.putData();
	getch();
}