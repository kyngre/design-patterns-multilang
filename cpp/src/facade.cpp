// facade.cpp
#include <iostream>
#include <string>

// 서브시스템 클래스들
class CPU {
public:
    void process() {
        std::cout << "CPU is processing data" << std::endl;
    }
};

class Memory {
public:
    void load() {
        std::cout << "Memory is loading data" << std::endl;
    }
};

class HardDrive {
public:
    void read() {
        std::cout << "Hard Drive is reading data" << std::endl;
    }
};

// 파사드 클래스
class Computer {
private:
    CPU cpu;
    Memory memory;
    HardDrive hardDrive;

public:
    void boot() {
        std::cout << "Computer is starting..." << std::endl;
        hardDrive.read();
        memory.load();
        cpu.process();
        std::cout << "Computer started successfully" << std::endl;
    }
};

// 테스트 코드
int main() {
    Computer computer;
    computer.boot();
    
    return 0;
}