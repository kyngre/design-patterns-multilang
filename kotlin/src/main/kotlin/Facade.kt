// Facade.kt
package designpatterns

// 서브시스템 클래스들
class CPU {
    fun process() {
        println("CPU is processing data")
    }
}

class Memory {
    fun load() {
        println("Memory is loading data")
    }
}

class HardDrive {
    fun read() {
        println("Hard Drive is reading data")
    }
}

// 파사드 클래스
class Computer {
    private val cpu = CPU()
    private val memory = Memory()
    private val hardDrive = HardDrive()

    fun boot() {
        println("Computer is starting...")
        hardDrive.read()
        memory.load()
        cpu.process()
        println("Computer started successfully")
    }
}

// 테스트 함수
fun testFacade() {
    val computer = Computer()
    computer.boot()
}