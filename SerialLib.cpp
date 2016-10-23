// SerialLib.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include <windows.h>
#include <stdio.h>

extern "C"
{
	__declspec(dllexport) HANDLE  __stdcall SerialConnect(char * name, DWORD baudrate)
	{
		HANDLE hCom;
		hCom = CreateFileA(name,                //port name
			GENERIC_READ | GENERIC_WRITE, //Read/Write
			0,                            // No Sharing
			NULL,                         // No Security
			OPEN_EXISTING,// Open existing port only
			0,            // Non Overlapped I/O
			NULL);        // Null for Comm Devices

		if (hCom == INVALID_HANDLE_VALUE) {
			MessageBoxA(0, "Error in opening serial port", "Error!", 1);
			return NULL;
		}
		DCB dcbSerialParams = { 0 };

		//Try to get the current
		if (!GetCommState(hCom, &dcbSerialParams))
		{
			MessageBoxA(0, "failed to get current serial parameters!", "Error!", 1);
		}
		dcbSerialParams.BaudRate = baudrate;
		dcbSerialParams.ByteSize = 8;
		dcbSerialParams.StopBits = ONESTOPBIT;
		dcbSerialParams.Parity = NOPARITY;
		//Setting the DTR to Control_Enable ensures that the Arduino is properly
		//reset upon establishing a connection
		dcbSerialParams.fDtrControl = DTR_CONTROL_ENABLE;

		//Set the parameters and check for their proper application
		if (!SetCommState(hCom, &dcbSerialParams))
		{
			MessageBoxA(0,"ALERT: Could not set Serial Port parameters", "Error!", 1);
		}
		return hCom;
	}

	__declspec(dllexport) bool __stdcall SerialWrite(HANDLE hCom, char * bytes, unsigned int numBytes) 
	{
		return WriteFile(hCom, bytes, numBytes, NULL, NULL);
	}
}

