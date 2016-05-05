# include<iostream>
# include<stdlib.h>
# include<string>
using namespace std;
char conver(int a){
	char b = a;
	return b;
}

int main(){
	int a;
	cout<<"ENTER ANY NUMBER: ";
	cin>>a;
	cout<<"character is:"<<conver(a)<<endl;
	system("PAUSE");	
	return 0;
}