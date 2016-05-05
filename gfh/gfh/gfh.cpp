// gfh.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

void gotoxy(short int col,short int row){
	HANDLE hStdout = GetStdHandle(STD_OUTPUT_HANDLE);
	COORD position = {col,row};
	SetConsoleCursorPosition(hStdout,position);
	}

int _tmain(int argc, _TCHAR* argv[])
{

	



	return 0;
}

