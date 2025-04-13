// Factory.kt
package designpatterns

// 추상 클래스
abstract class Animal {
    abstract fun speak(): String
}

// 구체 클래스들
class Dog : Animal() {
    override fun speak(): String {
        return "Woof!"
    }
}

class Cat : Animal() {
    override fun speak(): String {
        return "Meow!"
    }
}

// 팩토리 클래스
class AnimalFactory {
    fun createAnimal(animalType: String): Animal? {
        return when (animalType.lowercase()) {
            "dog" -> Dog()
            "cat" -> Cat()
            else -> null
        }
    }
}

// 테스트 함수
fun testFactory() {
    val factory = AnimalFactory()
    
    val dog = factory.createAnimal("dog")
    dog?.let { println("Dog says: ${it.speak()}") }
    
    val cat = factory.createAnimal("cat")
    cat?.let { println("Cat says: ${it.speak()}") }
}