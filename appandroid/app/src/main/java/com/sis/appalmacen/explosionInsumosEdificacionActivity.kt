package com.sis.appalmacen

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button

class explosionInsumosEdificacionActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_explosion_insumos_edificacion)

        val botonretroceso = findViewById<Button>(R.id.buttonAtras)

        botonretroceso.setOnClickListener {
            finish()
        }

    }
}