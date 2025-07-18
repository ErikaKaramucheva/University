package com.example.pharmacymobile

import android.annotation.SuppressLint
import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.ImageButton
import android.widget.TextView
import android.widget.Toast
import androidx.activity.ComponentActivity

class LoginActivity: ComponentActivity() {
    @SuppressLint("MissingInflatedId", "WrongViewCast")
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.login_activity)
        val btnLogin = findViewById<Button>(R.id.buttonLogin)
        val btnBack = findViewById<ImageButton>(R.id.btn_back)
        val btnProfile = findViewById<ImageButton>(R.id.btn_profile)
        val btnCart = findViewById<ImageButton>(R.id.btn_shopping_cart)
        val tv_reg=findViewById<TextView>(R.id.reg_tv)

         btnLogin.setOnClickListener {
                 val intent = Intent(this, MainActivity::class.java)
                 Toast.makeText(this,"Успешен вход",Toast.LENGTH_SHORT).toString()
                 startActivity(intent)
             finish()
             }
        btnBack.setOnClickListener {
            val intent = Intent(this, MainActivity::class.java)
            Toast.makeText(this,"Връщаме се една стъпка назад",Toast.LENGTH_SHORT).toString()
            startActivity(intent)
            finish()
        }
        btnProfile.setOnClickListener {
            val intent = Intent(this, LoginActivity::class.java)
            Toast.makeText(this,"Все още не сте влезли в своя профил...",Toast.LENGTH_SHORT).toString()
            startActivity(intent)
            finish()
        }
        btnCart.setOnClickListener {
            val intent = Intent(this, ShoppingCartActivity::class.java)
            Toast.makeText(this,"Да видим какво има в количката",Toast.LENGTH_SHORT).toString()
            startActivity(intent)
            finish()
        }
        tv_reg.setOnClickListener {
            val intent = Intent(this, RegisterActivity::class.java)
            Toast.makeText(this,"Преминаваме към екрана за регистрация",Toast.LENGTH_SHORT).toString()
            startActivity(intent)
            finish()
        }

         }

    }
