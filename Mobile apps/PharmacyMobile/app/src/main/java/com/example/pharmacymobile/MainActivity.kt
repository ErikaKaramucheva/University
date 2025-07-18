package com.example.pharmacymobile

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.ImageButton
import android.widget.Toast
import androidx.activity.ComponentActivity
import androidx.cardview.widget.CardView

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
            setContentView(R.layout.activity_main)
        val btnProfile = findViewById<ImageButton>(R.id.btn_profile)
        val btnCart = findViewById<ImageButton>(R.id.btn_shopping_cart)
        val mgLiquid=findViewById<CardView>(R.id.mg_liquid)


        btnProfile.setOnClickListener {
            val intent = Intent(this, LoginActivity::class.java)
            Toast.makeText(this,"Все още не сте влезли в своя профил...", Toast.LENGTH_SHORT).toString()
            startActivity(intent)
            finish()
        }
        btnCart.setOnClickListener {
            val intent = Intent(this, ShoppingCartActivity::class.java)
            Toast.makeText(this,"Да видим какво има в количката",Toast.LENGTH_SHORT).toString()
            startActivity(intent)
            finish()
        }
        mgLiquid.setOnClickListener {
            val intent = Intent(this, ShowPillActivity::class.java)
            Toast.makeText(this,"Зареждаме детайлите...",Toast.LENGTH_SHORT).toString()
            startActivity(intent)
            finish()
        }

        }
    }

