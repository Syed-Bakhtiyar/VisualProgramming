# include<iostream>
# include<stdlib.h>
using namespace std;
void hello(){
	cout<<"hello world";
}
void hello(int x){
	cout<<"\nfunction overload";
}
void hello(int y, int z){
	cout<<"\n 3rd function return";
}
int main(int x, char* s[]){
	hello();
	hello(1);
	hello(3,4);
	system("PAUSE");
return 0;
}