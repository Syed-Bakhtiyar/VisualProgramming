# include<iostream>
# include<cstdlib>
# include<time.h>
using namespace std;
int randomize(int rand1){
if(rand1%2 ==0){
	return rand1;
	}else if(rand1%2 !=0){
		rand1++;
		return rand1;
	}else{
	rand1 = 0;
	return rand1;
	}
}
int main(){
	int rand1=(rand()%10);
	rand1=randomize(rand1);
	cout<<"\nrandomize number is: "<<rand1<<endl;
	system("PAUSE");
return 0;
}