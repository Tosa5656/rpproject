#include <webview/webview.h>
#include <iostream>
#include <fstream>
#include <string>
#include <sstream>

std::string title = "Launcher";

std::string readIndex()
{
    std::stringstream ss;
    std::string line;
 
    std::ifstream in("resources/index.html");
    if (in.is_open())
    {
        while (std::getline(in, line))
        {
            ss << line;
        }
    }
    in.close();
    return ss.str();
}

int WINAPI WinMain(HINSTANCE hInst, HINSTANCE hPrevInst, LPSTR lpCmdLine, int nCmdShow) 
{
    webview::webview wview(false, nullptr);
    wview.set_title("Launcher");
    wview.set_size(1280, 720, WEBVIEW_HINT_FIXED);
    wview.set_html(readIndex());
    wview.run();
}