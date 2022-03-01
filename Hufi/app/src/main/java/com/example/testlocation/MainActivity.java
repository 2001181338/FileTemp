package com.example.testlocation;

import android.content.Context;
import android.database.Cursor;
import android.location.Location;
import android.location.LocationListener;
import android.location.LocationManager;
import android.net.Uri;
import android.os.Bundle;

import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.android.material.snackbar.Snackbar;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.provider.ContactsContract;
import android.util.Log;
import android.view.View;

import android.view.Menu;
import android.view.MenuItem;
import android.widget.ListView;
import android.widget.TextView;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    ArrayList<Contract> dulieu = new ArrayList<>();
    ContractAdapter adapter;
    ListView listViewContract;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        listViewContract = findViewById(R.id.listView);
        adapter = new ContractAdapter(this, R.layout.layout_contract, dulieu);
        listViewContract.setAdapter(adapter);

        LoadContracts();
    }

    private void LoadContracts(){
        Uri uri = Uri.parse("content://contracts/people");
        Cursor cursor = getContentResolver().query(uri, null, null, null, null);
        while(cursor.moveToNext()){
            Contract contract = new Contract();
            contract.hoTen = cursor.getString(cursor.getColumnIndex(ContactsContract.Contacts.DISPLAY_NAME));
            contract.soDienThoai = "123456";

            dulieu.add(contract);
        }
    }
}