# include<fstream>
# include<iostream>
using namespace std;
int main(){
	int x;
	int a=5;
	char b= 'b';
	double c = 2.5;
	float d =  2.5f;
	cout<<"1.write file\n2.read file\n";
	cin>>x;
	if(x==1){
	
	cin>>a;
	cin>>b;
	cin>>c;
	cin>>d;
	ofstream fout ("bakhtiyar.txt");
	fout<<a<<b<<c<<d;
	cout<<"file written\n";
	}else if(x==2)
		{
		fflush(stdout);
		ifstream fin("bakhtiyar.txt");
		cout<<a<<' '<<b<<' '<<c<<' '<<d;
	}
	system("PAUSE");
return 0;
}