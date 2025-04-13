// Adapter.kt
package designpatterns

// 내부 클래스 (Target)
open class InternalClass {
    open fun fetch(): String {
        return "get user info"
    }
}

// 외부 클래스 (Adaptee)
class ExternalClass {
    fun search(): String {
        return "get user info"
    }
}

// 어댑터 클래스
class Adapter(private val external: ExternalClass) : InternalClass() {
    override fun fetch(): String {
        return external.search()
    }
}

// 테스트 함수
fun testAdapter() {
    val internal = InternalClass()
    println("Internal class: ${internal.fetch()}")

    val external = ExternalClass()
    println("External class: ${external.search()}")

    val adapter = Adapter(external)
    println("Adapter: ${adapter.fetch()}")
}