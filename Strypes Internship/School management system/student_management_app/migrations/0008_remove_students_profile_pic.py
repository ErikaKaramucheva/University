# Generated by Django 3.0.7 on 2022-11-14 16:07

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('student_management_app', '0007_auto_20221114_1226'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='students',
            name='profile_pic',
        ),
    ]
