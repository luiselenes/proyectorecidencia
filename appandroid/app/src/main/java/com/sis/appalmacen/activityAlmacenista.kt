package com.sis.appalmacen

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button

class activityAlmacenista : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_almacenista)

        val botonreque = findViewById<Button>(R.id.btnProcesarRequisicionInsumos)
        val botonEntradaInsumos = findViewById<Button>(R.id.btnEntradaInsumos)


        botonreque.setOnClickListener{
            val intento1 = Intent(this, requisicionTablaActivity::class.java)
            startActivity(intento1)
        }


        botonEntradaInsumos.setOnClickListener{
            val intento2 = Intent(this, expplosionInsumosEdificacionTablaActivity::class.java)
            startActivity(intento2)
        }

    }
}