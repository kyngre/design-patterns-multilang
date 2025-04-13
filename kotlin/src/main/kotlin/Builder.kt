// Builder.kt
package designpatterns

// 계산기 클래스 (메소드 체이닝)
class Calculator {
    private var result = 0.0

    fun add(value: Double): Calculator {
        result += value
        return this
    }

    fun subtract(value: Double): Calculator {
        result -= value
        return this
    }

    fun multiply(value: Double): Calculator {
        result *= value
        return this
    }

    fun divide(value: Double): Calculator {
        if (value != 0.0) {
            result /= value
        }
        return this
    }

    fun getResult(): Double {
        return result
    }
}

// Person 클래스 (빌더 패턴 + 메소드 체이닝)
class Person {
    var name: String = ""
    var age: Int = 0
    var address: String = ""
    
    fun display() {
        println("Name: $name, Age: $age, Address: $address")
    }

    // Kotlin에서는 companion object를 통해 정적 빌더 패턴을 구현할 수 있음
    class Builder {
        private val person = Person()

        fun withName(name: String): Builder {
            person.name = name
            return this
        }

        fun withAge(age: Int): Builder {
            person.age = age
            return this
        }

        fun withAddress(address: String): Builder {
            person.address = address
            return this
        }

        fun build(): Person {
            return person
        }
    }
}

// 테스트 함수
fun testBuilder() {
    // 계산기 예제 - 메소드 체이닝
    val calc = Calculator()
    val result = calc.add(5.0).multiply(2.0).subtract(3.0).divide(2.0).getResult()
    println("Calculator result: $result")

    // Person 빌더 예제
    val person = Person.Builder()
        .withName("홍길동")
        .withAge(20)
        .withAddress("양산시 부산대학로")
        .build()
    
    person.display()
}