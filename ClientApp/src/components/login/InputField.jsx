function InputField({
  onChange,
  name,
  value,
  type,
  description,
  placeholder,
  disabled,
  required,
}) {
  return (
    <div>
      <label htmlFor={name}>{description}</label>
      <div className="input-group mb-3">
        <input
          type={type ? type : "string"}
          className="form-control"
          id={name}
          name={name}
          value={value}
          onChange={(e) => onChange(e)}
          placeholder={placeholder}
          disabled={disabled}
          required={required}
        />
      </div>
    </div>
  );
}

export default InputField;
