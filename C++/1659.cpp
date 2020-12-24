#include <iomanip>
#include <iostream>

struct point
{
    double x, y;
    point(double x = 0, double y = 0) : x(x), y(y) { }
    point operator- (const point& p) const { return point(x-p.x, y-p.y); }
    point operator/ (double t) const { return point(x/t, y/t); }
    point operator+ (const point& p) const { return point(x+p.x, y+p.y); }
};

int main()
{
    point tri[3], in[3], out[3];
    for(int i = 0; i < 3; i++)
        std::cin >> tri[i].x >> tri[i].y;
    in[0] = (tri[0] + tri[1] + tri[2])/3;
    for(int i = 0; i < 3; i++)
        out[i] = in[0] + (in[0] - tri[i]);
    in[1] = in[0] + (tri[1] - in[0])/3;
    in[2] = in[0] + (out[2] - in[0])/3;
    for(int i = 0; i < 3; i++)
        std::cout << std::setprecision(10) << std::fixed << in[i].x << " " << in[i].y << "\n";
    for(int i = 0; i < 3; i++)
        std::cout << std::setprecision(10) << std::fixed << out[i].x << " " << out[i].y << "\n";
}