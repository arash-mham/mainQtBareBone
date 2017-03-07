#include<Qt\qapplication.h>
#include"GLWindow.h"
int main(int argc, char* argv[])
{
	QApplication app(argc, argv);
	QWidget widge;
	widge.show();
	GLWindow glWindow;
	glWindow.show();
	return app.exec();
}