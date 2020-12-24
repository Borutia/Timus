#include <iostream>
#include <cstring>
#include <cstdlib>

int num_of_cities;
int path_length;
int** graph;
bool* visited;

void dfs(int vertex, int length) {
	if (visited[vertex] || length >= path_length) {
		std::cout << "YES";
		exit(0);
	}

	visited[vertex] = true;
	for (int i = 0; i < num_of_cities; ++i) {
		int value = graph[vertex][i];
		if (value != 0) {
			graph[i][vertex] = 0;
			dfs(i, length + value);
			graph[i][vertex] = value;
		}
	}
}

void solve() {
	visited = new bool[num_of_cities];
	for (int i = 0; i < num_of_cities; ++i) {
		memset(visited, 0, num_of_cities * sizeof(bool));
		dfs(i, 0);
	}
	
}



int main() {
	int n;
	std::cin >> num_of_cities >> n >> path_length;

	graph = new int*[num_of_cities];
	for (int i = 0; i < num_of_cities; ++i) {
		graph[i] = new int[num_of_cities];
		memset(graph[i], 0, num_of_cities * sizeof(int));
	}

	for (int i = 0; i < n; ++i) {
		int p, q, r;
		std::cin >> p >> q >> r;

		--p;
		--q;
		if (graph[p][q] != 0 || graph[q][p] != 0) {
			std::cout << "YES";
			return 0;
		}
		graph[p][q] = r;
		graph[q][p] = r;
	}

	solve();
	std::cout << "NO";
	return 0;
}