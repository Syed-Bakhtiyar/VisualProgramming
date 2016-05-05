# include<iostream>
# include<stdlib.h>
# include<fstream>
# include<conio.h>
# include<string.h>
# include<stdio.h>
using namespace std;
struct data{
	int age;
	char name[40];
	float salary;
};
int main(){
	fstream obj;
	data ins;
	int size = sizeof ins,choice;
	start:
	obj.open("record.DAT",ios::binary|ios::out|ios::in);
/*	if(obj==NULL){
		obj.open("record.DAT",ios::out);
		goto start;
	}*/
	do{
	cout<<"\n1. add data\n2. read data\n3. modify data\n4 to delete data\n6.exit\nEnter your choice";
	flushall();
	choice=getche();
	if(choice=='1'){
		obj.seekp(0,ios::end);
		char another='y';
		while(another=='y'){
			cout<<"\nEnter a name: ";
			flushall();
			gets(ins.name);
			cout<<"Enter age: ";
			cin>>ins.age;
			cout<<"Enter basic salary: ";
			cin>>ins.salary;
			obj.write(reinterpret_cast<char*>(&ins),size);
			cout<<"\nAre you wan't to add another record? y/n: ";
			another=getche();
		}
	
	}
	else if(choice=='2'){
		obj.seekg(0);
		obj.read(reinterpret_cast <char*>(&ins),size);
		
		while(!obj.eof()){
			cout<<ins.name;
			cout<<ins.age;
			cout<<ins.salary;
			cout<<obj.tellg();
			//obj.read(reinterpret_cast <char*>(&ins),size);
			
		}
	
	}
	else if(choice=='3'){
	
	}
	else if(choice=='4'){
	
	}
	else if(choice=='5'){
		obj.close();
		exit(0);
	}

	
	
	
	}while(1);
	//system("PAUSE");
return 0;
}