package com.example.pharmacymobile

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.ImageButton
import android.widget.TextView
import android.widget.Toast
import androidx.activity.ComponentActivity

class RegisterActivity: ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.register_activity)
        val btnBack=findViewById<ImageButton>(R.id.btn_back)
        val btnRegister=findViewById<Button>(R.id.btn_register)
        val btnProfile=findViewById<ImageButton>(R.id.btn_profile)
        val btnCart=findViewById<ImageButton>(R.id.image_shopping_cart)
        val tv_log=findViewById<TextView>(R.id.tv_log)



        btnRegister.setOnClickListener {
            val intent = Intent(this, MainActivity::class.java)
            Toast.makeText(this,"Успешна регистрация", Toast.LENGTH_SHORT).toString()
            startActivity(intent)
            finish()
        }
        btnBack.setOnClickListener {
            val intent = Intent(this, LoginActivity::class.java)
            Toast.makeText(this,"Връщаме се една стъпка назад", Toast.LENGTH_SHORT).toString()
            startActivity(intent)
            finish()
        }
        btnProfile.setOnClickListener {
            val intent = Intent(this, LoginActivity::class.java)
            Toast.makeText(this,"Все още не сте влезли в своя профил...", Toast.LENGTH_SHORT).toString()
            startActivity(intent)
            finish()
        }
        btnCart.setOnClickListener {
            val intent = Intent(this, ShoppingCartActivity::class.java)
            Toast.makeText(this,"Да видим какво има в количката", Toast.LENGTH_SHORT).toString()
            startActivity(intent)
            finish()
        }
        tv_log.setOnClickListener {
            val intent = Intent(this, LoginActivity::class.java)
            Toast.makeText(this,"Преминаваме към екрана за вход",Toast.LENGTH_SHORT).toString()
            startActivity(intent)
            finish()
        }
    }
}