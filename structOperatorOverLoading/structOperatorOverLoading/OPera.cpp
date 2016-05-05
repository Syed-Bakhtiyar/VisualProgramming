# include<iostream>
# include<conio.h>
using namespace std;
struct op{
	int a[2];
	op(){
	
	}
	op(int x,int y){
	a[0]=x;
	a[1]=y;
	}
	op operator +(op n){
		int temp1 = a[0]+n.a[0];
		int temp2 = a[1]+ n.a[1];
		op temp(temp1,temp2);

		return temp;
	}
	void print(){
	cout<<endl<<a[0];
	cout<<endl<<a[1];
	
	}



};
int main(){
	op a(3,2),b(2,5),c;
	c=a+b;
	c.print();
getch();
}
