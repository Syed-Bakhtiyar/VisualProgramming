# include<iostream>
# include<conio.h>
# include<stdlib.h>
using namespace std;
class data{
public:
	int info;
	data *ptr;
	


};
data *beg;
void add (int num){
	

}
int main(){
	beg->ptr=NULL;
	cout<<"\t\tSTACK WITH THE HELP OF LINKED LIST\n";
	int num;
	data *temp,*arzi;
	cout<<"1.insert data\n2.delete data\n3.display\n4.exit\n";
	cin>>num;
	do{
	if(num ==1){
		
		int entry;
		cin>>entry;
		if(temp->ptr == beg){
			arzi = new data;
		}else{
			temp = new data;
			temp->info= entry;
			temp->ptr = beg;
		}
		
	}else
	if(num==2){
		
	}else
	if(num==3){
		
	}else
	if(num==4){
	exit(0);
	}
	}while(1);
	
	getch();
return 0;
}