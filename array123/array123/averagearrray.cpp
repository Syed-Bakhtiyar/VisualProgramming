# include<iostream>
# include<stdlib.h>
# include<time.h>
using namespace std;
void average(int[],int  );
int main(){
const int limit =10;
int arrray[limit];

int i;
for(i=0;i<limit;i++){
	cin>>arrray[i];
}
average(arrray,limit);

const int size =5;
cout<<"\n enter second array\n";
int barray[size];
for(i=0;i<size;i++){
	barray[i]=(rand()%90);
}
for(i=0;i<size;i++){
	cout<<barray[i]<<endl;
}
average(barray,size);
system("PAUSE");
return 0;
}
void average(int arrray[],int limit ){
	int temp=0;
	int i;
	for(i=0;i<limit;i++){
	temp+=arrray[i];
	}
	int answer = temp/limit;
	cout<<answer;
}