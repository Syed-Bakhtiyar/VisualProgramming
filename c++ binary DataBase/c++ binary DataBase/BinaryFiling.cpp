# include<iostream>
# include<stdlib.h>
# include<string>
# include<conio.h>
# include<string.h>
# include<fstream>
using namespace std;
class Data{

public:	
	int age;
	char name[80];
	void SetData(){
	cout<<"\nEnter name: ";
	gets(name);
	cout<<"Enter Age: ";
	cin>>age;
	}
	void getData(){
		for(int i=0;i<80;i++){
		name[i] = ' ';
		}
	cout<<endl<<name<<endl;
	cout<<age;
	}
};
int main(){
Data a;
string b = "bakhtiyar",n="bakhtiyara";
cout<<"\ncomparison is: "<<b.compare(n)<<endl;

int choice;
int size = sizeof(a);
do{
cout<<"1.insert\n2.read\n3.search\n4.delete\n5.exit\nenter your choice: ";
choice = getch();
if(choice=='1'){

	a.SetData();
	ofstream outfile("record.DAT",ios::binary);
	outfile.write(reinterpret_cast<char*>(&a),sizeof (a));
	outfile.close();
}
if(choice =='2'){
	ifstream infile("record.DAT",ios::binary);
	infile.read(reinterpret_cast<char*>(&a),sizeof (a));
	a.getData();
	getch();
	infile.close();

}
if(choice == '3'){
	char temp[80];
	cout<<"\nenter name to find in data: ";
	ifstream search("record.DAT",ios::binary| ios::beg);
//	search.seekg(size,0);
	gets(temp);
	
	
	//while(!search.eof()){
		if(strcmp(a.name,temp)==0){
			search.read(reinterpret_cast<char*>(&a),sizeof(a));
			cout<<a.name;
			cout<<endl<<a.age;
		
		}
	//}
	search.close();
}
if(choice == '4'){
	ifstream infile("record.DAT",ios::binary);
	infile.read(reinterpret_cast <char*>(&a),sizeof(a));
	ofstream outfile("temp.DAT",ios::binary);
	outfile.write(reinterpret_cast<char*>(&a),sizeof(a));
	outfile.close();
	infile.close();
	remove("record.DAT");
	getch();
	rename("temp.DAT","record.DAT");
}
if(choice == '5'){
	exit(0);
}
} while(1);
system("PAUSE");
return 0;
}
