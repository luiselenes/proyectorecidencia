package com.sis.appalmacen

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.content.Intent
import android.view.View
import android.widget.Button

class activityAlmacenista : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_almacenista)

        val botonbuscar = findViewById<Button>(R.id.btnBuscarInsumo)

        botonbuscar.setOnClickListener{
            val intentBuscar = Intent(this, MostrarTodosProductosActivity::class.java)
            startActivity(intentBuscar)
        }

    }


}