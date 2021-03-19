
//LogicClientHome - start

//sub_6C03B0 start 
encoder.WriteVInt(2020260);
encoder.WriteVInt(67238);
encoder.WriteVInt(99999);
encoder.WriteVInt(99999);
encoder.WriteVInt(122);
encoder.WriteVInt(200);
encoder.WriteVInt(99999);

ByteStreamHelper.WriteDataReference(encoder, 28, 0);
ByteStreamHelper.WriteDataReference(encoder, 43, 0);

encoder.WriteVInt(0);

encoder.WriteVInt(0);

encoder.WriteVInt(0);

encoder.WriteVInt(0);

encoder.WriteVInt(0);

encoder.WriteVInt(0);
encoder.WriteVInt(0);
encoder.WriteVInt(0);
encoder.WriteVInt(0);

encoder.WriteBoolean(false);

encoder.WriteVInt(1000);
encoder.WriteVInt(10);
encoder.WriteVInt(20);
encoder.WriteVInt(30);

//sub_2C3314 - start
encoder.WriteVInt(0);
encoder.WriteVInt(0);
encoder.WriteVInt(0);
//sub_2C3314 - end

encoder.WriteBoolean(false);

encoder.WriteBoolean(false);

encoder.WriteBoolean(false);
encoder.WriteVInt(0);
encoder.WriteVInt(0);
encoder.WriteVInt(0);
encoder.WriteVInt(0);
encoder.WriteVInt(0);

encoder.WriteVInt(0);

encoder.WriteVInt(0);

encoder.WriteVInt(200);
encoder.WriteVInt(0);

encoder.WriteVInt(0);

encoder.WriteVInt(99999);
encoder.WriteVInt(0);

ByteStreamHelper.WriteDataReference(encoder, 16, 0);

encoder.WriteString("RU");
encoder.WriteString("Mr Vitalik");

encoder.WriteVInt(1);
{
	encoder.WriteInt(0);
	encoder.WriteInt(0);
}

encoder.WriteVInt(1);
{
	encoder.WriteVInt(0);

	ByteStreamHelper.WriteDataReference(encoder, 16, 0);

	encoder.WriteVInt(0);
}

encoder.WriteVInt(1);
{
	encoder.WriteVInt(4);
	encoder.WriteVInt(99999);
	encoder.WriteBoolean(true);
	encoder.WriteVInt(1);
	encoder.WriteBoolean(false);

	encoder.WriteBoolean(true);
	{
		encoder.WriteInt(0);
		encoder.WriteInt(0);
		encoder.WriteInt(0);
		encoder.WriteInt(0);
	}

	encoder.WriteBoolean(true);
	{
		encoder.WriteInt(4);
		encoder.WriteInt(0);
		encoder.WriteInt(0);
		encoder.WriteInt(0);
	}
}

encoder.WriteVInt(1);
{
	encoder.WriteVInt(0);
	encoder.WriteVInt(0);
}

encoder.WriteBoolean(true);
{
	encoder.WriteVInt(0);
}

encoder.WriteBoolean(true);
{
	encoder.WriteVInt(0);
}

encoder.WriteBoolean(false);
//sub_6C03B0 end 

encoder.WriteVInt(0);

encoder.WriteVInt(9);
for (int i = 0; i < 9; i++)
{
	encoder.WriteVInt(i);
}

encoder.WriteVInt(1);
{
	encoder.WriteVInt(0);
	encoder.WriteVInt(1);
	encoder.WriteVInt(0);
	encoder.WriteVInt(75992);
	encoder.WriteVInt(10);

	ByteStreamHelper.WriteDataReference(encoder, 15, 7);

	encoder.WriteVInt(0);
	encoder.WriteVInt(3);

	encoder.WriteString(null);

	encoder.WriteVInt(0);
	encoder.WriteVInt(0);
	encoder.WriteVInt(0);
	encoder.WriteVInt(0);

	encoder.WriteVInt(0);
	encoder.WriteVInt(0);

	encoder.WriteBoolean(false);

	encoder.WriteVInt(0);

	encoder.WriteBoolean(false);
}

encoder.WriteVInt(0);

encoder.WriteVInt(0);
encoder.WriteVInt(0);
encoder.WriteVInt(0); 
encoder.WriteVInt(0);

encoder.WriteBoolean(false);

encoder.WriteVInt(0);
encoder.WriteVInt(0);
encoder.WriteVInt(0);
encoder.WriteVInt(0);

encoder.WriteInt(0);
encoder.WriteInt(1);

encoder.WriteVInt(0);
encoder.WriteVInt(0);

encoder.WriteBoolean(false);
encoder.WriteVInt(0);

encoder.WriteVInt(0);

//LogicClientHome - end

//LogicClientAvatar - start

encoder.WriteVInt(0);
encoder.WriteVInt(1);

encoder.WriteVInt(0);
encoder.WriteVInt(1);

encoder.WriteVInt(0);
encoder.WriteVInt(1);

encoder.WriteString("Mr Vitalik");
encoder.WriteByte(1); //name set by user

encoder.WriteInt(0);

encoder.WriteVInt(8);

encoder.WriteVInt(0);

encoder.WriteVInt(0);

encoder.WriteVInt(0);

encoder.WriteVInt(0);

encoder.WriteVInt(0);

encoder.WriteVInt(0);

encoder.WriteVInt(0);

encoder.WriteVInt(0);

encoder.WriteVInt(999999);
encoder.WriteVInt(999999);
encoder.WriteVInt(0);
encoder.WriteVInt(0);
encoder.WriteVInt(0);
encoder.WriteVInt(0);
encoder.WriteVInt(0);
encoder.WriteVInt(0);
encoder.WriteVInt(0);
encoder.WriteVInt(0);
encoder.WriteVInt(0);
encoder.WriteVInt(2);
			
//LogicClientAvatar - end		

encoder.WriteVInt(0); //timer