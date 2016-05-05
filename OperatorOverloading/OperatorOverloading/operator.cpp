//       +, - , * , /, = , += ,-= ,*= ,/= ,== ,> , < , [] , !=
# include<iostream>                  
# include<stdlib.h>
# include<conio.h>
# include<stdio.h>
using namespace std;
class op{
private:
	int arr[2];
public:
	op(){}
	/////////////////
	op(int a,int b) {
		arr[0]=a;
		arr[1]=b;
	}
	/////////////////
	void set(int a,int b){
		arr[0]=a;
		arr[1]=b;
	}
	/////////////////////
	void getarr(){
	cout<<"\n first value is: "<<arr[0];
	cout<<"\n second value is: "<<arr[1];
	}
	////////////////////
	op operator +(op b){
		int add = arr[0]+b.arr[0];
		int add2 = arr[1]+b.arr[1];
		op temp(add,add2);
		return temp;
		}
	///////////////////
	op operator -(op b){
		int sub = arr[0]-b.arr[0];
		int sub2 = arr[1]-b.arr[1];
		op temps(sub,sub2);
		return temps;
	}
	//////////////////
	op operator / (int a){
		if(a==0){
		printf("can't divide by zero");
		}else{
		
		int divide= arr[0]/a;
		int divide2= arr[1]/a;
		op temp(divide,divide2);
		return temp;
		}
	}
	///////////////////
	op operator * (int a){
		int multiply = arr[0]*a;
		int multiply2 = arr[1]*a;
		op temp(multiply,multiply2);
		return temp;
	}
	//////////////////
	bool operator ==(op b){
		if(arr[0]==b.arr[0] && arr[1]==b.arr[1]){
			return true;	
		}else{
		return false;
		}
	}
	//////////////////
	bool operator !=(op b){
		if(arr[0]!=b.arr[0]&&arr[1]!=b.arr[1]){
		return true;
		}else{
		return false;
		}
	}
	////////////////
	bool operator >(op b){
		if(arr[0]>b.arr[0]&&arr[1]>b.arr[1]){
		return true;
		}else{
			return false;
		}
	}
	//////////////////
	bool operator <(op b ){
		if(arr[0]<b.arr[0]&&arr[1]<b.arr[1]){
		return true;
		}else{
			return false;
		}
	}
	void operator [](int a){
	cout<<"BOUND CHECKING:";
	
	}
};
int main(){
	op a,b,c;
	bool tf;
	int w,x,y,z;
	char l;
	cout<<"1.+ op\n2.- op\n3./ op\n4.* op\n5.== op\n6.!= op\n7.> op\n8.< op\n9.[] op\n0.exit\n";
	printf("ENTER YOUR CHOICE: ");
	l= getche();
	switch(l){
	case '1':
		printf("\n\nENTER FIRST NUMBER : ");
		cin>>w;
		printf("\nENTER SECOND NUMBER : ");
		cin>>x;
		printf("\nENTER third NUMBER : ");
		cin>>y;
		printf("\nENTER FOURTH NUMBER: ");
		cin>>z;
		a.set(w,x);
		b.set(y,z);
		c=a+b;
		c.getarr();
		break;
	case '2':
		printf("\n\nENTER FIRST5 NUMBER: ");
		flushall();
		cin>>w;
		printf("\nENTER SECOND NUMBER: ");
		flushall();
		cin>>x;
		printf("\nENTER THIRD NUMBER: ");
		flushall();
		cin>>y;
		printf("\nENTER FOURTH NUMBER: ");
		flushall();
		cin>>z;
		a.set(w,x);
		b.set(y,z);
		c=a-b;
		c.getarr();
		break;
	case '3':
		printf("\nENTER FIRST NUMBER: ");
		cin>>w;
		printf("ENTER SECOND NUMBER: ");
		cin>>x;
		a.set(w,x);
		printf("\nWHAT NUMBER WHOULD YOU LIKE TO DIVIDE? ");
		int k;
		cin>>k;
		c=a/k;
		c.getarr();
		break;
	case '4':
		printf("\nENTER FIRST NUMBER: ");
		cin>>w;
		printf("\nENTER SECOND NUMBER: ");
		cin>>x;
		a.set(w,x);
		printf("\nWHAT NUMBER WHOULD YOU LIKE TO MULTIPLY? ");
		cin>>k;
		c=a*k;
		c.getarr();
		break;
	case '5':
		printf("\nENTER FIRST NUMBER: ");
		cin>>w;
		printf("\nENTER SECOND NUMBER: ");
		cin>>x;
		printf("\nENTER THIRD NUMBER: ");
		cin>>y;
		printf("\nENTER FOURTH NUMBER: ");
		cin>>z;
		a.set(w,x);
		b.set(y,z);
		tf = a==b;
		cout<<"1. true and 0.false: "<<tf;
		break;
	case '6':
		printf("\nENTER FIRST NUMBER: ");
		cin>>w;
		printf("\nENTER SECOND NUMBER: ");
		cin>>x;
		printf("\nENTER THIRD NUMBER: ");
		cin>>y;
		printf("\nENTER FOURTH NUMBER: ");
		a.set(w,x);
		b.set(y,z);
		tf =a!=b;
		cout<<"1.true and 0.false: "<<tf;
		break;
	case '7':
		printf("\nENTER FIRST NUMBER: ");
		cin>>w;
		printf("\nENTER SECOND NUMBER: ");
		cin>>x;
		printf("\nENTER THIRD NUMBER: ");
		cin>>y;
		printf("\nENTER FOURTH NUMBER: ");
		cin>>z;
		a.set(w,x);
		b.set(y,z);
		tf = a>b;
		cout<<"1. true and 0.false: "<<tf;
		break;
	case '8':
		printf("\nENTER FIRST NUMBER: ");
		cin>>w;
		printf("\nENTER SECOND NUMBER: ");
		cin>>x;
		printf("\nENTER THIRD NUMBER: ");
		cin>>y;
		printf("\nENTER FOURTH NUMBER: ");
		cin>>z;
		a.set(w,x);
		b.set(y,z);
		tf = a<b;
		cout<<"1.true and 0.false: "<<tf;
		break;
	case '9':
		printf("for warm up :)");
		a[x];
		break;
	case '0':
		exit(0);
		break;
	default:
		cout<<"ENTER A WRONG NUMBER: ";
	}
printf("\n\n\n");
system("PAUSE");
return 0;
}