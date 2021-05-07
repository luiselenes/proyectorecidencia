package com.sis.appalmacen

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button

class MostrarTodosProductosActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_mostrar_todos_productos)

        val btnImagen = findViewById<Button>(R.id.btnImagenProducto)

        btnImagen.setOnClickListener{
            val intento1 = Intent(this, ProductDetailActivity::class.java)
            startActivity(intento1)
        }

    }
}