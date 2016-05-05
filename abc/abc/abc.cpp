#include<iostream>
#include<conio.h>
#include<stdlib.h>
#include<stdio.h>
#include<string.h>

using namespace std;
class stringg{
private:
	char arr1[81];
	char arr2[81];
public:
	void add(){
		cout<<"\nENTER FIRST LINE"<<endl;
		gets(arr1);
		cout<<"\nENTER SECOND LINE"<<endl;
		gets(arr2); 
	}

	void upp(){
		cout<<"1. for 1st string uppercase";
		cout<<"\n2. for 1st string uppercase";
	int a;
	if((a=getche())=='1'){
		cout<<endl << strupr(arr1);
	}
	else
		if((a=getch())=='2'){
			cout<<endl << strupr(arr2);
		}
	}

	void low(){
		cout<<"1. for 1st string lowercase";
		cout<<"\n2. for 1st string lowercase";
	int a;
	if((a=getch())=='1'){
		cout<<endl << strlwr(arr1);
	}
	else
		if((a=getch())=='2'){
			cout<<endl << strlwr(arr2);
		}
	}

	int compare(){
	int temp;
	temp = strcmp( arr2 , arr1 );
	return temp;
	}

	void length(){
	int temp;
	cout<<"1. for 1st string length"<<endl; 
	cout<<"2. for 2nd string length"<<endl;
	char a=getche();
	switch (a){
	case '1':
		temp= strlen(arr1);
		cout<<"\nlength of no 1 sentence is: "<<temp<<endl;
		break;
	case '2':
		temp= strlen(arr2);
		cout<<"\nlength of no 2 sentence is: "<<temp<<endl;
		break;
	default:
		cout<<"WRONG NUMBER";
	}
	   }
};

int main(){
	stringg a;
	
	do{
		cout<<"\n1.add\n2.upper\n3.low\n4.cmp\n5.length\n6.exit\n";
		char b = getche();
		switch(b){
		case '1':
			a.add();
			break;
		case '2':
			a.upp();
			break;
		case '3':
			a.low();
			break;
		case '4':
			cout<<a.compare();
			break;
		case '5':
			a.length();
			break;
		case '6':
			exit(0);
			break;

		default:
			cout<<"bhen k loray sahi entry maar: ";
		
		
		}
	}
	while(1);
	
	return 0;
}