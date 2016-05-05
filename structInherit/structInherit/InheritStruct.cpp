# include<iostream>
# include<stdlib.h>
# include<string>
using namespace std;
struct name{
	string nam;
	name(){
	nam = "parent";
	}
	void parent(){
	cout<<nam;
	}
	void reco(){
	cout<<"\n\n\nover ride method";
	}
};
struct mm : name{
	void child(){
	cout<<"child";
	}
	void reco(){
	cout<<"over ride karne wala method";
	}
};
int main(){
	name a;
	mm b;
	a.parent();
	cout<<endl;
	b.child();	cout<<endl;
	
	b.reco();
	cout<<"\n";
	a.reco();
	cout<<endl;
	system("PAUSE");
return 0;
}


